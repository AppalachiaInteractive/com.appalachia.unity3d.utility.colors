using UnityEngine;

namespace Appalachia.Utility.Colors
{
    public static partial class Colors
    {
        public static Color UpdateR(this Color color, float value)
        {
            return UpdateRed(color, value);
        }

        public static Color UpdateG(this Color color, float value)
        {
            return UpdateGreen(color, value);
        }

        public static Color UpdateB(this Color color, float value)
        {
            return UpdateBlue(color, value);
        }

        public static Color UpdateA(this Color color, float value)
        {
            return UpdateAlpha(color, value);
        }

        public static Color UpdateRed(this Color color, float value)
        {
            return new(value, color.g, color.b, color.a);
        }

        public static Color UpdateGreen(this Color color, float value)
        {
            return new(color.r, value, color.b, color.a);
        }

        public static Color UpdateBlue(this Color color, float value)
        {
            return new(color.r, color.g, value, color.a);
        }

        public static Color UpdateAlpha(this Color color, float value)
        {
            return new(color.r, color.g, color.b, value);
        }
    }
}
