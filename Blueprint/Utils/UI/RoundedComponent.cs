using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text;

namespace Blueprint.Utils.UI
{
    public class RoundedComponent : UserControl
    {
        private int _borderRadius = 10;
        private int _borderWidth = 1;
        private Color _borderColor = Color.Gray;
        private int _borderPadding = 0;
        private Color _innerColor = Color.Transparent;

        // Новое свойство: отступы для дочерних контролов
        private Padding _contentPadding = new Padding(0);

        public RoundedComponent()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.OptimizedDoubleBuffer, true);

            this.DoubleBuffered = true;
        }

        // Свойство: Радиус скругления
        [Category("Appearance")]
        [Description("Радиус скругления углов")]
        [DefaultValue(10)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = Math.Max(0, value);
                UpdateRegion();
                Invalidate();
            }
        }

        // Свойство: Толщина рамки
        [Category("Border")]
        [Description("Толщина рамки")]
        [DefaultValue(1)]
        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                _borderWidth = Math.Max(0, value);
                UpdateContentPadding();
                UpdateRegion();
                Invalidate();
            }
        }

        // Свойство: Цвет рамки
        [Category("Border")]
        [Description("Цвет рамки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        // Свойство: Отступ рамки от края
        [Category("Border")]
        [Description("Отступ рамки от края контрола")]
        [DefaultValue(0)]
        public int BorderPadding
        {
            get => _borderPadding;
            set
            {
                _borderPadding = Math.Max(0, value);
                UpdateContentPadding();
                UpdateRegion();
                Invalidate();
            }
        }

        // Свойство: Цвет внутри рамки (фон за рамкой)
        [Category("Border")]
        [Description("Цвет внутри рамки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color InnerColor
        {
            get => _innerColor;
            set
            {
                _innerColor = value;
                Invalidate();
            }
        }

        // Новое свойство для правильного размещения дочерних контролов
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Padding ContentPadding => _contentPadding;

        // Метод для обновления отступов контента
        private void UpdateContentPadding()
        {
            int padding = _borderPadding + _borderWidth;
            _contentPadding = new Padding(padding, padding, padding, padding);
        }

        // Метод для получения прямоугольника с учетом отступов
        private Rectangle GetBorderRectangle()
        {
            int padding = _borderPadding + (_borderWidth / 2);
            return new Rectangle(
                padding,
                padding,
                Width - padding * 2 - 1,
                Height - padding * 2 - 1
            );
        }

        // Метод для получения прямоугольника фона
        private Rectangle GetBackgroundRectangle()
        {
            int totalPadding = _borderPadding + _borderWidth;
            return new Rectangle(
                totalPadding,
                totalPadding,
                Width - totalPadding * 2,
                Height - totalPadding * 2
            );
        }

        private void UpdateRegion()
        {
            if (BorderRadius > 0 && Width > 0 && Height > 0)
            {
                var rect = new Rectangle(0, 0, Width, Height);
                var path = GetRoundedPath(rect, BorderRadius);
                Region = new Region(path);
            }
            else
            {
                Region = null;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Рисуем фон
            if (BackColor != Color.Transparent)
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    if (BorderRadius > 0)
                    {
                        var bgRect = GetBackgroundRectangle();
                        if (bgRect.Width > 0 && bgRect.Height > 0)
                        {
                            using (var path = GetRoundedPath(bgRect,
                                   Math.Max(0, BorderRadius - _borderWidth - _borderPadding)))
                            {
                                e.Graphics.FillPath(brush, path);
                            }
                        }
                    }
                    else
                    {
                        e.Graphics.FillRectangle(brush, GetBackgroundRectangle());
                    }
                }
            }

            // 2. Рисуем внутренний цвет (между рамкой и фоном)
            if (_innerColor != Color.Transparent && _borderWidth > 0)
            {
                using (var brush = new SolidBrush(_innerColor))
                using (var path = GetRoundedPath(GetBorderRectangle(),
                       Math.Max(0, BorderRadius - _borderPadding)))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            // 3. Рисуем рамку
            if (_borderWidth > 0 && _borderColor != Color.Transparent)
            {
                using (var pen = new Pen(_borderColor, _borderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;

                    if (BorderRadius > 0)
                    {
                        using (var path = GetRoundedPath(GetBorderRectangle(),
                               Math.Max(0, BorderRadius - _borderPadding)))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                    else
                    {
                        var borderRect = GetBorderRectangle();
                        e.Graphics.DrawRectangle(pen, borderRect);
                    }
                }
            }

            // 4. Рисуем текст
            if (!string.IsNullOrEmpty(Text))
            {
                using (var brush = new SolidBrush(ForeColor))
                {
                    var stringFormat = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Учитываем отступы при рисовании текста
                    var textRect = new Rectangle(
                        _borderPadding + _borderWidth,
                        _borderPadding + _borderWidth,
                        Width - (_borderPadding + _borderWidth) * 2,
                        Height - (_borderPadding + _borderWidth) * 2
                    );

                    e.Graphics.DrawString(Text, Font, brush, textRect, stringFormat);
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            // Ограничиваем радиус половиной меньшей стороны
            int maxRadius = Math.Min(rect.Width, rect.Height) / 2;
            radius = Math.Min(radius, maxRadius);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Вместо переопределения ClientRectangle используем этот метод
        public Rectangle GetContentRectangle()
        {
            int padding = _borderPadding + _borderWidth;
            return new Rectangle(
                padding,
                padding,
                Width - padding * 2,
                Height - padding * 2
            );
        }

        // Корректируем позицию дочерних контролов при изменении отступов
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            AdjustChildControl(e.Control);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            foreach (Control child in Controls)
            {
                if (!child.IsDisposed)
                {
                    AdjustChildControl(child);
                }
            }
        }

        private void AdjustChildControl(Control child)
        {
            int padding = _borderPadding + _borderWidth;

            // Если контрол находится слишком близко к краю - сдвигаем
            if (child.Left < padding)
                child.Left = padding;

            if (child.Top < padding)
                child.Top = padding;

            // Проверяем правую и нижнюю границы
            if (child.Right > Width - padding)
                child.Width = Math.Max(0, Width - padding - child.Left);

            if (child.Bottom > Height - padding)
                child.Height = Math.Max(0, Height - padding - child.Top);
        }
    }
}
