using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Blueprint.Utils.UI {
    public class GlassUIForm : Form {
        // Constants for accent states
        public const int ACCENT_DISABLED = 0;
        public const int ACCENT_ENABLE_BLURBEHIND = 3;
        public const int ACCENT_ENABLE_ACRYLICBLURBEHIND = 4;
        public const int ACCENT_ENABLE_GRADIENT = 1;
        public const int ACCENT_ENABLE_TRANSPARENTGRADIENT = 2;

        // Windows constant for accent policy
        private const int WCA_ACCENT_POLICY = 19;

        // Form State (Drag)
        //private bool _isDragging = false;
        private int _currentAccentState = ACCENT_ENABLE_ACRYLICBLURBEHIND;

        // Form properties
        public int EFFECT = ACCENT_ENABLE_BLURBEHIND;
        public bool ShowFormIcon = true;
        public bool ShowFormText = true;
        public int FormOpacity = 128;
        public int BackFormOpacity = 128;

        // Structure for accent policy
        [StructLayout(LayoutKind.Sequential)]

        public struct ACCENT_POLICY {
            public int nAccentState;
            public int nFlags;
            public int nColor;
            public int nAnimationId;
        }


        // ========== [ SHADOW ] ==========
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        private const int WM_ENTERSIZEMOVE = 0x0231;
        private const int WM_EXITSIZEMOVE = 0x0232;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_ENTERSIZEMOVE:
                    // Начали перемещать окно
                    _currentAccentState = EFFECT;
                    SetAccentState(ACCENT_ENABLE_BLURBEHIND);
                    break;

                case WM_EXITSIZEMOVE:
                    // Закончили перемещение
                    SetAccentState(_currentAccentState);
                    break;

                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS
                        {
                            bottomHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
            }

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }
        // ========== [ /SHADOW ] ==========


        // P/Invoke for Windows APIs
        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDesktopWindow();

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

        [DllImport("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        
        [DllImport("gdi32.dll")]
        private static extern bool DeleteDC(IntPtr hdc);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        
        // Set DPI awareness
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        // Structure for window composition attribute data
        [StructLayout(LayoutKind.Sequential)]
        public struct WindowCompositionAttributeData {
            public int Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }


        // Structure for rectangle
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }


        // Form fields
        private Form backgroundForm;
        private Bitmap backgroundBitmap;

        private const int WS_EX_NOREDIRECTIONBITMAP = 0x00200000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // Критически важно для производительности Acrylic!
                //cp.ExStyle |= WS_EX_NOREDIRECTIONBITMAP;

                // shadow
                m_aeroEnabled = CheckAeroEnabled();
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        // constructor
        public GlassUIForm() {
            // Set DPI awareness for versions >= 6
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            // Set form properties
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            Load += Blur_Opacity_Load; // Subscribe to the Load event
            TopMost = true;
        }

        // Load event handler
        private void Blur_Opacity_Load(object sender, EventArgs e) {
            // Initialize background form, apply transparency, and initialize close button
            //InitializeBackgroundForm();
            ApplyTransparency();
        }


        // Initialize background form
        private void InitializeBackgroundForm() {
            backgroundForm = new Form();
            backgroundForm.FormBorderStyle = FormBorderStyle.None;
            backgroundForm.StartPosition = FormStartPosition.Manual;
            backgroundForm.ShowInTaskbar = false;
            backgroundForm.BackColor = Color.Black;
            backgroundForm.Opacity = BackFormOpacity / 255f; // Adjust the opacity as needed
            Rectangle screenBounds = Screen.FromControl(this).Bounds;
            backgroundForm.Bounds = screenBounds;
            backgroundForm.Show();
            backgroundForm.Paint += BackgroundForm_Paint;
            backgroundForm.Click += BackgroundForm_Click;
            backgroundForm.TopMost = true;
            MakeBackgroundClickThrough();
        }

        // Make background form click through
        private void MakeBackgroundClickThrough() {
            int extendedStyle = GetWindowLong(backgroundForm.Handle, -20);
            SetWindowLong(backgroundForm.Handle, -20, extendedStyle | WS_EX_TRANSPARENT);
        }
        
        // Background form click event handler
        private void BackgroundForm_Click(object sender, EventArgs e) {
            TopMost = true;
        }

        // Background form paint event handler
        private void BackgroundForm_Paint(object sender, PaintEventArgs e) {
            if (backgroundBitmap != null) {
                using (Graphics g = e.Graphics) {
                    g.DrawImage(backgroundBitmap, 0, 0);
                }
            }
        }

        // Apply transparency
        private void ApplyTransparency() {
            ACCENT_POLICY accent = new ACCENT_POLICY();
            accent.nAccentState = EFFECT;
            accent.nFlags = 2;
            accent.nColor = Color.FromArgb(FormOpacity, Color.FromArgb(BackColor.B, BackColor.G, BackColor.R)).ToArgb();
            accent.nAnimationId = 0;

            WindowCompositionAttributeData data = new WindowCompositionAttributeData();
            data.Attribute = WCA_ACCENT_POLICY;
            data.SizeOfData = Marshal.SizeOf(accent);
            data.Data = Marshal.AllocHGlobal(data.SizeOfData);
            Marshal.StructureToPtr(accent, data.Data, false);

            SetWindowCompositionAttribute(this.Handle, ref data);

            Marshal.FreeHGlobal(data.Data);
        }

        // Extended window style constant
        private const int WS_EX_TRANSPARENT = 0x20;

        // Structure for drawing round rectangle
        public static class ExtDrawing2D {
            public static GraphicsPath GetRoundedRect(RectangleF rect, float radius) {
                GraphicsPath path = new GraphicsPath();
                float diameter = radius * 2.0f;
                SizeF sizeF = new SizeF(diameter, diameter);
                RectangleF arc = new RectangleF(rect.Location, sizeF);
                path.AddArc(arc, 180, 90);
                arc.X = rect.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = rect.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = rect.Left;
                path.AddArc(arc, 90, 90);
                path.CloseFigure();
                return path;
            }

            public static void FillRoundRect(Graphics g, Brush brush, RectangleF rect, float radius) {
                GraphicsPath path = GetRoundedRect(rect, radius);
                g.FillPath(brush, path);
            }

            public static void DrawRoundRect(Graphics g, Pen pen, RectangleF rect, float radius) {
                GraphicsPath path = GetRoundedRect(rect, radius);
                g.DrawPath(pen, path);
            }
        }

        // Set accent state
        private void SetAccentState(int accentState) {
            ACCENT_POLICY accent = new ACCENT_POLICY();
            accent.nAccentState = accentState;
            accent.nFlags = 2;
            accent.nColor = Color.FromArgb(FormOpacity, BackColor).ToArgb();
            accent.nAnimationId = 0;

            WindowCompositionAttributeData data = new WindowCompositionAttributeData();
            data.Attribute = WCA_ACCENT_POLICY;
            data.SizeOfData = Marshal.SizeOf(accent);
            data.Data = Marshal.AllocHGlobal(data.SizeOfData);
            Marshal.StructureToPtr(accent, data.Data, false);

            SetWindowCompositionAttribute(this.Handle, ref data);

            Marshal.FreeHGlobal(data.Data);
        }


        // Mouse down event override
        //protected override void OnMouseDown(MouseEventArgs e) {
        //    base.OnMouseDown(e);
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        _isDragging = true;

        //        // Сохраняем текущий эффект
        //        _currentAccentState = EFFECT;

        //        // Временно отключаем эффект
        //        SetAccentState(ACCENT_ENABLE_BLURBEHIND);

        //        // Начинаем перетаскивание
        //        MoveWindow(Handle);
        //    }
        //}

        // Обработчик движения мыши для возврата эффекта
        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);

        //    if (_isDragging && !IsMouseDown())
        //    {
        //        _isDragging = false;

        //        // Включаем эффект обратно с задержкой
        //        Task.Delay(10).ContinueWith(t =>
        //        {
        //            this.Invoke((MethodInvoker)delegate
        //            {
        //                SetAccentState(_currentAccentState);
        //            });
        //        });
        //    }
        //}

        // Импорт для GetAsyncKeyState
        //[DllImport("user32.dll")]
        //private static extern short GetAsyncKeyState(int vKey);

        // Вспомогательный метод для проверки нажатия мыши
        //private bool IsMouseDown()
        //{
        //    return (GetAsyncKeyState(0x01) & 0x8000) != 0;
        //}


        // Move window
        //private void MoveWindow(IntPtr hWnd) {
        //    ReleaseCapture();
        //    SendMessage(hWnd, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        //}

        // P/Invoke for Windows messages
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        // Windows messages constants
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;
        private const int HTCAPTION = 0x0002;

        // Paint event override
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Transparent);

            // Draw form border
            //using (Pen borderPen = new Pen(Color.Aqua, 2)) {
            //    e.Graphics.DrawRectangle(borderPen, 1, 1, this.ClientSize.Width - 2, this.ClientSize.Height - 2);
            //}


            // Draw background image with reduced opacity
            if (this.BackgroundImage != null) {
                Bitmap bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
                using (Graphics g = Graphics.FromImage(bmp)) {
                    ColorMatrix matrix = new ColorMatrix();
                    matrix.Matrix33 = 0.2f;
                    ImageAttributes attributes = new ImageAttributes();
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(this.BackgroundImage, ClientRectangle, 0, 0, this.BackgroundImage.Width, this.BackgroundImage.Height, GraphicsUnit.Pixel, attributes);
                }
                e.Graphics.DrawImage(bmp, 0, 0);
            }

            base.OnPaint(e);
        } 
    } 
}