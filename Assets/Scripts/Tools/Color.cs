using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color 
{
    public static UnityEngine.Color Black;
    public static UnityEngine.Color Silver;
    public static UnityEngine.Color Grey;
    public static UnityEngine.Color White;
    public static UnityEngine.Color Maroon;
    public static UnityEngine.Color Red;
    public static UnityEngine.Color Purple;
    public static UnityEngine.Color Fuchsia;
    public static UnityEngine.Color Green;
    public static UnityEngine.Color Lime;
    public static UnityEngine.Color Yellow;
    public static UnityEngine.Color Blue;
    public static UnityEngine.Color Cyan;

    public List<UnityEngine.Color> allColor;

    public Color()
    {
        ColorUtility.TryParseHtmlString("#000000", out Black);
        ColorUtility.TryParseHtmlString("#C0C0C0", out Silver);
        ColorUtility.TryParseHtmlString("#808080", out Grey);
        ColorUtility.TryParseHtmlString("#FFFFFF", out White);
        ColorUtility.TryParseHtmlString("#800000", out Maroon);
        ColorUtility.TryParseHtmlString("#FF0000", out Red);
        ColorUtility.TryParseHtmlString("#800080", out Purple);
        ColorUtility.TryParseHtmlString("#FF00FF", out Fuchsia);
        ColorUtility.TryParseHtmlString("#008000", out Green);
        ColorUtility.TryParseHtmlString("#00FF00", out Lime);
        ColorUtility.TryParseHtmlString("#FFFF00", out Yellow);
        ColorUtility.TryParseHtmlString("#0000F0", out Blue);
        ColorUtility.TryParseHtmlString("#00FFFF", out Cyan);
        allColor = new List<UnityEngine.Color>();
        InitColor();
    }

    private void InitColor()
    {
        allColor.Add(Blue);
        allColor.Add(Red);
        allColor.Add(Cyan);
        allColor.Add(Yellow);
        allColor.Add(Fuchsia);
        allColor.Add(Lime);
    }

    public UnityEngine.Color GetRandomColor()
    {
        int random = Random.Range(0, allColor.Count);
        return allColor[random];
    }
}
