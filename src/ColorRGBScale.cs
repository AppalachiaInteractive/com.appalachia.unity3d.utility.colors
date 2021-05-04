using UnityEngine;

namespace Appalachia.Utility.Colors
{
    public static partial class Colors
    {
        public static Color ScaleR(this Color color, float factor)
        {
            return ScaleRed(color, factor);
        }

        public static Color ScaleG(this Color color, float factor)
        {
            return ScaleGreen(color, factor);
        }

        public static Color ScaleB(this Color color, float factor)
        {
            return ScaleBlue(color, factor);
        }

        public static Color ScaleA(this Color color, float factor)
        {
            return ScaleAlpha(color, factor);
        }

        public static Color ScaleRed(this Color color, float factor)
        {
            return new Color(color.r * factor, color.g, color.b, color.a);
        }

        public static Color ScaleGreen(this Color color, float factor)
        {
            return new Color(color.r, color.g * factor, color.b, color.a);
        }

        public static Color ScaleBlue(this Color color, float factor)
        {
            return new Color(color.r, color.g, color.b * factor, color.a);
        }

        public static Color ScaleAlpha(this Color color, float factor)
        {
            return new Color(color.r, color.g, color.b, color.a * factor);
        }
    }
}
