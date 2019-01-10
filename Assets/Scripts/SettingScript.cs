﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScript : MonoBehaviour
{
    public List<Color> SelectedBubbleColors;

    public static Dictionary<string, Color> ColorDico;
    public static Color Black;
    public static Color Silver;
    public static Color Grey;
    public static Color White;
    public static Color Maroon;
    public static Color Red;
    public static Color Purple;
    public static Color Fuchsia;
    public static Color Green;
    public static Color Lime;
    public static Color Yellow;
    public static Color Blue;
    public static Color Cyan;
    public void InitGame()
    {
        ColorUtility.TryParseHtmlString("#000000", out Black);
        ColorUtility.TryParseHtmlString("#000000", out Silver);
        ColorUtility.TryParseHtmlString("#000000", out Grey);
        ColorUtility.TryParseHtmlString("#000000", out White);
        ColorUtility.TryParseHtmlString("#000000", out Maroon);
        ColorUtility.TryParseHtmlString("#000000", out Red);
        ColorUtility.TryParseHtmlString("#000000", out Purple);
        ColorUtility.TryParseHtmlString("#000000", out Fuchsia);
        ColorUtility.TryParseHtmlString("#000000", out Green);
        ColorUtility.TryParseHtmlString("#000000", out Lime);
        ColorUtility.TryParseHtmlString("#000000", out Yellow);
        ColorUtility.TryParseHtmlString("#000000", out Blue);
        ColorUtility.TryParseHtmlString("#000000", out Cyan);
        ColorDico = new Dictionary<string, Color>() {
            { "Black", Black},
            { "Silver",Silver},
            { "Grey",Grey},
            { "White",White},
            { "Maroon",Maroon},
            { "Red",Red},
            { "Purple",Purple},
            { "Fuchsia",Fuchsia},
            { "Green",Green},
            { "Lime",Lime},
            { "Yellow",Yellow},
            { "Blue",Blue},
            { "Cyan",Cyan},
        };
    }


    // Start is called before the first frame update
    void Start()
    {
        firstInit();
        SelectedBubbleColors.Capacity = 6;
        //get seleted item to fill list
        //UpdateSelectedColors();

        SelectedBubbleColors.Add(Color.black);
        SelectedBubbleColors.Add(Color.blue);
        SelectedBubbleColors.Add(Color.red);
        SelectedBubbleColors.Add(Color.green);
        SelectedBubbleColors.Add(Color.magenta);
        SelectedBubbleColors.Add(Color.yellow);
    }

    private void firstInit()
    {
        if (PlayerPrefs.GetString("Color1") == null)
        {
            PlayerPrefs.SetString("BubbleColor1", "");
            PlayerPrefs.SetString("BubbleColor2", "");
            PlayerPrefs.SetString("BubbleColor3", "");
            PlayerPrefs.SetString("BubbleColor4", "");
            PlayerPrefs.SetString("BubbleColor5", "");
            PlayerPrefs.SetString("BubbleColor6", "");
        }
    }

    private void UpdateSelectedColors()
    {
        SelectedBubbleColors.Clear();
        //SelectedBubbleColors.Add(fromPlayerPrefs.GetString("Color1"));
        //Color.
        //PlayerPrefs.GetString("Color2");
        PlayerPrefs.GetString("Color3");
        PlayerPrefs.GetString("Color4");
        PlayerPrefs.GetString("Color5");
        PlayerPrefs.GetString("Color6");
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateSelectedColors();
    }
}
