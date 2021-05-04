using UnityEngine;

namespace Appalachia.Utility.Colors
{
    public static partial class Colors
    {
        public static Color ScaleH(this Color color, float factor, bool allowHdr = true)
        {
            return ScaleHue(color, factor, allowHdr);
        }

        public static Color ScaleS(this Color color, float factor, bool allowHdr = true)
        {
            return ScaleSaturation(color, factor, allowHdr);
        }

        public static Color ScaleV(this Color color, float factor, bool allowHdr = true)
        {
            return ScaleValue(color, factor, allowHdr);
        }

        public static Color ScaleHue(this Color color, float factor, bool allowHdr = true)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue * factor, sat, value, allowHdr);
        }

        public static Color ScaleSaturation(this Color color, float factor, bool allowHdr = true)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, sat * factor, value, allowHdr);
        }

        public static Color ScaleValue(this Color color, float factor, bool allowHdr = true)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, sat, value * factor, allowHdr);
        }
    }
}
