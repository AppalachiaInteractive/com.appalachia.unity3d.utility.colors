using UnityEngine;

namespace Appalachia.Utility.Colors
{
    public static partial class  Colors
    {
        public static Color SetH(this Color color, float value)
        {
            return SetHue(color, value);
        }

        public static Color SetS(this Color color, float value)
        {
            return SetSaturation(color, value);
        }

        public static Color SetV(this Color color, float value)
        {
            return SetValue(color, value);
        }

        public static Color UpdateH(this Color color, float value)
        {
            return UpdateHue(color, value);
        }

        public static Color UpdateS(this Color color, float value)
        {
            return UpdateSaturation(color, value);
        }

        public static Color UpdateV(this Color color, float value)
        {
            return UpdateValue(color, value);
        }

        public static Color SetHue(this Color color, float newHue)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, newHue, value);
        }

        public static Color SetSaturation(this Color color, float newSaturation)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, newSaturation, value);
        }

        public static Color SetValue(this Color color, float newValue)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, newValue, value);
        }

        public static Color UpdateHue(this Color color, float newHue)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, newHue, value);
        }

        public static Color UpdateSaturation(this Color color, float newSaturation)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, newSaturation, value);
        }

        public static Color UpdateValue(this Color color, float newValue)
        {
            Color.RGBToHSV(color, out var hue, out var sat, out var value);
            return Color.HSVToRGB(hue, newValue, value);
        }

        public static Color BlendHSV(this Color color, Color other)
        {
            Color.RGBToHSV(color, out var hue1, out var sat1, out var value1);
            Color.RGBToHSV(color, out var hue2, out var sat2, out var value2);

            var c = Color.HSVToRGB((hue1 + hue2) / 2f, (sat1 + sat2) / 2f, (value1 + value2) / 2f);

            c.a = (color.a + other.a) / 2f;

            return c;
        }

        public static Color BlendRGB(this Color color, Color other)
        {

            var c = new Color((color.r + other.r) / 2f, (color.g + other.g) / 2f, (color.b + other.b) / 2f, (color.a + other.a) / 2f);
            return c;
        }
    }
}
