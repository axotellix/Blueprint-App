using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Blueprint.Utils.UI
{
    public static class GlassUIColors
    {

        public static Color White = Color.FromArgb(224, 233, 241);              // White
        public static Color Dark = Color.FromArgb(13, 14, 15);                  // Dark
        public static Color GreyDark = Color.FromArgb(19, 20, 21);              // Grey-Dark
        public static Color GreyBorder = Color.FromArgb(32, 33, 35);            // Grey-Border
        public static Color Grey = Color.FromArgb(96, 103, 110);                // Grey
        public static Color GreyCard = Color.FromArgb(27, 29, 31);              // Grey-Card
        public static Color GreyCardLight = Color.FromArgb(38, 41, 43);         // Grey-Card-Light
        public static Color GreyBorderLight = Color.FromArgb(37, 39, 41);       // Grey-Border-Light
        public static Color GreyBorderExtraLight = Color.FromArgb(45, 49, 51);  // Grey-Border-Extra-Light
        public static Color Red = Color.FromArgb(166, 104, 106);                // Red

        /// <summary>
        /// Осветляет цвет на указанный процент (0.0 - 1.0)
        /// </summary>
        public static Color Lighten(this Color color, int percent)
        {
            float p = percent * 1.0f / 100;
            // Ограничиваем проценты
            p = Math.Max(0, Math.Min(1, p));

            // Переводим в HSL для более естественного осветления
            return LightenByHSL(color, percent);
        }

        /// <summary>
        /// Осветление через RGB (просто, но не идеально)
        /// </summary>
        public static Color LightenByRGB(this Color color, int percent)
        {
            float p = percent * 1.0f / 100;

            int r = (int)(color.R + (255 - color.R) * p);
            int g = (int)(color.G + (255 - color.G) * p);
            int b = (int)(color.B + (255 - color.B) * p);

            return Color.FromArgb(color.A, r, g, b);
        }

        /// <summary>
        /// Осветление через HSL (лучший результат)
        /// </summary>
        public static Color LightenByHSL(this Color color, int percent)
        {
            float p = percent * 1.0f / 100;

            // Конвертируем в HSL
            ColorToHSL(color, out float h, out float s, out float l);

            // Увеличиваем Lightness
            l = Math.Min(1.0f, l + (1.0f - l) * p);

            // Конвертируем обратно в RGB
            return HSLToColor(h, s, l);
        }

        /// <summary>
        /// Затемняет цвет на указанный процент
        /// </summary>
        public static Color Darken(this Color color, int percent)
        {
            float p = percent * 1.0f / 100;
            p = Math.Max(0, Math.Min(1, p));

            ColorToHSL(color, out float h, out float s, out float l);
            l = l * (1.0f - p); // Уменьшаем Lightness

            return HSLToColor(h, s, l);
        }

        // Конвертация RGB → HSL
        private static void ColorToHSL(Color color, out float h, out float s, out float l)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));

            // Lightness
            l = (max + min) / 2f;

            if (Math.Abs(max - min) < 0.00001f)
            {
                h = s = 0f; // Оттенок серого
                return;
            }

            // Saturation
            s = l > 0.5f ? (max - min) / (2f - max - min) : (max - min) / (max + min);

            // Hue
            if (Math.Abs(max - r) < 0.00001f)
                h = (g - b) / (max - min);
            else if (Math.Abs(max - g) < 0.00001f)
                h = 2f + (b - r) / (max - min);
            else
                h = 4f + (r - g) / (max - min);

            h *= 60f;
            if (h < 0f) h += 360f;
            h /= 360f; // Нормализуем к 0-1
        }

        // Конвертация HSL → RGB
        private static Color HSLToColor(float h, float s, float l)
        {
            float r, g, b;

            if (s < 0.00001f)
            {
                r = g = b = l; // Оттенок серого
            }
            else
            {
                float q = l < 0.5f ? l * (1f + s) : l + s - l * s;
                float p = 2f * l - q;

                r = HueToRGB(p, q, h + 1f / 3f);
                g = HueToRGB(p, q, h);
                b = HueToRGB(p, q, h - 1f / 3f);
            }

            return Color.FromArgb(
                (int)(r * 255f),
                (int)(g * 255f),
                (int)(b * 255f)
            );
        }

        private static float HueToRGB(float p, float q, float t)
        {
            if (t < 0f) t += 1f;
            if (t > 1f) t -= 1f;

            if (t < 1f / 6f) return p + (q - p) * 6f * t;
            if (t < 1f / 2f) return q;
            if (t < 2f / 3f) return p + (q - p) * (2f / 3f - t) * 6f;
            return p;
        }
    }
}
