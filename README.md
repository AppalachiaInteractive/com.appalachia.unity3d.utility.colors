# Appalachia.Utility.Colors for Unity3D
##  The color API that you deserve.  Extension methods and fluent API for working with color in Unity3D.
### Created by Appalachia Interactive
com.appalachia.unity3d.utility.colors

``` cs
// Properties for 547 HTML colors
var aqua = Colors.Aquamarine1;
// Get a color by enum - again, 547 options.
var coral = Colors.Enum.LightCoral.ToColor();
```
``` cs
// Use color hex codes with flexible parsing.  
var invisibleBlack = "#00000000".ColorFromHex()
var red = "#FFFF0000".ColorFromHex()
red = "ffff0000".ColorFromHex()
red = Colors.FromHexCode("ff0000");
// You can also output hex codes using color.ToHexCode();
red.ToHexCode(includeNumberSign:true, includeAlpha:false); // #FF0000
```
``` cs
// Color blending
Color myBlend = Colors.RawSienna.BlendHSV(Colors.BurntUmber)     
                                .BlendRGB(Colors.Crimson);
```
``` cs
// Color modification
Color warmerCobalt = Colors.Cobalt.UpdateSaturation(.85f).ScaleValue(.5f).ScaleRed(1.3f);
```
``` cs
// Serializable reference type wrapper - pass your color as an argument to methods.
// Never again forget to reassign value back.
ColorRef color = Color.black;
color.UpdateHue(.7f);
color.Blend(Color.Red);
Color myColor = color;  // Implicit casting back and forth.
```

### Features
- 547 HTML colors available
- XML documentation calls out HEX, HSV, and RGB color codes.
- `Colors.Enum` enumeration includes all 547 colors.
- Helpful functions for blending or modifying colors.
- Correct - thousands of test cases confirming the colors and functions are working as expected.

### All HTML colors as properties
![image](https://user-images.githubusercontent.com/18542093/117010475-d60cf500-acba-11eb-9ee0-db5de3971e6e.png)

### XML documentation calls out HEX, HSV, and RGB color codes
![image](https://user-images.githubusercontent.com/18542093/117010061-6a2a8c80-acba-11eb-8549-b1b2675023be.png)

### `Colors.Enum` enumeration includes all 547 colors.
``` cs
...
/// <summary>
///     [HEX] #0000FF <br />
///     [HSV] 240 100 100 <br />
///     [RGB] 000 000 255 <br />
/// </summary>
Blue = 458,

/// <summary>
///     [HEX] #483D8B <br />
///     [HSV] 248 056 054 <br />
///     [RGB] 072 061 139 <br />
/// </summary>
DarkSlateBlue = 459,

/// <summary>
///     [HEX] #473C8B <br />
///     [HSV] 248 056 054 <br />
///     [RGB] 071 060 139 <br />
/// </summary>
SlateBlue4 = 460,

/// <summary>
///     [HEX] #6A5ACD <br />
///     [HSV] 248 056 080 <br />
///     [RGB] 106 090 205 <br />
/// </summary>
SlateBlue = 461,
...
```

### Helpful functions for blending or modifying colors.
``` cs
public static void ToHSV(this Color color, out float h, out float s, out float v);

public static Color BlendHSV(this Color color, Color other);
public static Color BlendRGB(this Color color, Color other);

public static Color UpdateH(this Color color, float value, bool allowHdr = true);
public static Color UpdateS(this Color color, float value, bool allowHdr = true);
public static Color UpdateV(this Color color, float value, bool allowHdr = true);

public static Color UpdateR(this Color color, float value);
public static Color UpdateG(this Color color, float value);
public static Color UpdateB(this Color color, float value);
public static Color UpdateA(this Color color, float value);

public static Color ScaleH(this Color color, float factor, bool allowHdr = true);
public static Color ScaleS(this Color color, float factor, bool allowHdr = true);
public static Color ScaleV(this Color color, float factor, bool allowHdr = true);

public static Color ScaleR(this Color color, float factor);
public static Color ScaleB(this Color color, float factor);
public static Color ScaleG(this Color color, float factor);
public static Color ScaleA(this Color color, float factor);

public static Color UpdateHue(this Color color, float newHue, bool allowHdr = true);
public static Color UpdateSaturation(this Color color, float newSaturation, bool allowHdr = true);
public static Color UpdateValue(this Color color, float newValue, bool allowHdr = true);

public static Color UpdateBlue(this Color color, float value);
public static Color UpdateRed(this Color color, float value);
public static Color UpdateGreen(this Color color, float value);
public static Color UpdateAlpha(this Color color, float value);

public static Color ScaleHue(this Color color, float factor, bool allowHdr = true);
public static Color ScaleSaturation(this Color color, float factor, bool allowHdr = true);
public static Color ScaleValue(this Color color, float factor, bool allowHdr = true);

public static Color ScaleRed(this Color color, float factor);
public static Color ScaleGreen(this Color color, float factor);
public static Color ScaleBlue(this Color color, float factor);
public static Color ScaleAlpha(this Color color, float factor)
```
