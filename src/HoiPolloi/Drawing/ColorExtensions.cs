using System;
using System.Drawing;

namespace HoiPolloi.Drawing
{
    public static class ColorExtensions
    {
        public static string ToRgbString(this Color value)
        {
            return String.Format("{0:X2}{1:X2}{2:X2}", value.R, value.G, value.B);
        }

        public static Color ToColorFromRgbString(this string value)
        {
            if (!String.IsNullOrWhiteSpace(value)) {
                if (value[0] != '#') value = ('#' + value);

                try {
                    return ColorTranslator.FromHtml(value);
                } catch { /* Empty */ }
            }

            return Color.Empty;
        }
    }
}
