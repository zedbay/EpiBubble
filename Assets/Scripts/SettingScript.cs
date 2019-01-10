using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScript : MonoBehaviour
{
    public List<Color> SelectedBubbleColors;

<<<<<<< HEAD
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
=======
    // Start is called before the first frame update
    void Start()
    { 
        //get seleted item to fill list
        //UpdateSelectedColors();   
    }

    private void UpdateSelectedColors()
    {
        SelectedBubbleColors.Clear();
    }

    private void UpdateSelectedSpeed(string value)
    {
        PlayerPrefs.SetString("SelectedSpeed", value);
        int nbr = PlayerPrefs.GetString("SelectedSpeed") == "low" ? 80 :
         PlayerPrefs.GetString("SelectedSpeed") == "normal" ? 150 : 300;
        PlayerPrefs.SetInt("SpeedShotBubble", nbr);
    }

    private void UpdateSelectedDifficulty(string value)
    {
        PlayerPrefs.SetString("Difficulty", value);
        int nbr = PlayerPrefs.GetString("Difficulty") == "easy" ?  10 :
         PlayerPrefs.GetString("Difficulty") == "classic" ?  6 : 3;
        PlayerPrefs.SetInt("CountOfShotBeforeBubbleInsertion",nbr);
    }

    private void UpdateArrowColor(string value)
    {
        PlayerPrefs.SetString("ArrowColor", value);
    }

    private void UpdateCountOfShotBeforeBubbleInsertion(int value)
    {
        PlayerPrefs.SetInt("CountOfShotBeforeBubbleInsertion", value);
    }

    private void UpdateSpeedShotBubble(int value)
    {
        PlayerPrefs.SetInt("SpeedShotBubble", value);
    }

    private void UpdateCountOfBubbleToExplode(int value)
    {
        PlayerPrefs.SetInt("CountOfBubbleToExplode", value);
    }

    private void UpdateCountOfBubbleColor(int value)
    {
        PlayerPrefs.SetInt("CountOfBubbleColor", value);
    }

    private void UpdateCountOfBubbleRow(int value)
    {
        PlayerPrefs.SetInt("CountOfBubbleRow", value);
    }

    private void UpdateCountOfBubbleColumn(int value)
    {
        PlayerPrefs.SetInt("CountOfBubbleColumn", value);
    }

    private void UpdateVolum(int value)
    {
        PlayerPrefs.SetInt("Volum", value);
>>>>>>> b280bd419c010b27a49c0af33f9b91f947263a13
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        //UpdateSelectedColors();
=======
        //put all
>>>>>>> b280bd419c010b27a49c0af33f9b91f947263a13
    }
}
