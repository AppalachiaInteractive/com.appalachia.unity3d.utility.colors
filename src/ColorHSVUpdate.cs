using UnityEngine;

namespace Appalachia.Utility.Colors
{
    public static partial class Colors
    {
        public static Color UpdateH(this Color color, float value, bool allowHdr = true)
        {
            return UpdateHue(color, value, allowHdr);
        }

        public static Color UpdateS(this Color color, float value, bool allowHdr = true)
        {
            return UpdateSaturation(color, value, allowHdr);
        }

        public static Color UpdateV(this Color color, float value, bool allowHdr = true)
        {
            return UpdateValue(color, value, allowHdr);
        }

        public static Color UpdateHue(this Color color, float newHue, bool allowHdr = true)
        {
            Color.RGBToHSV(color, out _, out var sat, out var value);
            return Color.HSVToRGB(newHue, sat, value, allowHdr);
        }

        public static Color UpdateSaturation(this Color color, float newSaturation, bool allowHdr = true)
        {
            Color.RGBToHSV(color, out var hue, out _, out var value);
            return Color.HSVToRGB(hue, newSaturation, value, allowHdr);
        }

        public static Color UpdateValue(this Color color, float newValue, bool allowHdr = true)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out _);
            return Color.HSVToRGB(hue, sat, newValue, allowHdr);
        }
    }
}