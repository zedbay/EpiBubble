using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    #region UsersSetting
    public List<Color> SelectedBubbleColor;
    public Color SelectedarrowColor;
    public static int CountOfBubbleColor;
    public int CountOfBubbleRow;
    public int CountOfBubbleColumn;
    public int CountOfBubbleToExplode;
    public int CountOfShotBeforeBubbleInsertion;
    public int SpeedShotBubble;
    public string Difficulty;
    public static string SelectedSpeed;
    public int Volum;
    #endregion
    #region ColorsDico
    public static Dictionary<string, Color> ColorDico;
    public static Dictionary<string, Color> arrowColorDico;
    #endregion
    #region Colors
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
    #endregion
    #region ArrowColors
    public static Color arrowAstral;
    public static Color arrowRose;
    public static Color arrowOlive;
    public static Color arrowGrey;
    public static Color arrowMaroon;
    public static Color arrowGold;
    #endregion

    public void InitializeValues()
    {
        SelectedBubbleColor = new List<Color>();
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
            { "Cyan",Cyan}
        };

        ColorUtility.TryParseHtmlString("#327DA0", out arrowAstral);
        ColorUtility.TryParseHtmlString("#F64A8A", out arrowRose);
        ColorUtility.TryParseHtmlString("#808000", out arrowOlive);
        ColorUtility.TryParseHtmlString("#808080", out arrowGrey);
        ColorUtility.TryParseHtmlString("#800000", out arrowMaroon);
        ColorUtility.TryParseHtmlString("#FFD700", out arrowGold);

        arrowColorDico = new Dictionary<string, Color>() {
            { "Astral", arrowAstral},
            { "Rose",arrowRose},
            { "Olive",arrowOlive},
            { "Grey",arrowGrey},
            { "Maroon",arrowMaroon},
            { "Gold",arrowGold}
        };
    }
    // Start is called before the first frame update
    void Start()
    {
        InitializeValues();
        firstInit();
        getSettingValues();      
    }

    private void getSettingValues()
    {

        CountOfBubbleColor = PlayerPrefs.GetInt("CountOfBubbleColor");
        CountOfBubbleRow = PlayerPrefs.GetInt("CountOfBubbleRow");
        CountOfBubbleColumn = PlayerPrefs.GetInt("CountOfBubbleColumn");
        CountOfBubbleToExplode = PlayerPrefs.GetInt("CountOfBubbleToExplode");

        Difficulty = PlayerPrefs.GetString("Difficulty");
        SelectedSpeed = PlayerPrefs.GetString("SelectedSpeed");
        CountOfShotBeforeBubbleInsertion = PlayerPrefs.GetInt("CountOfShotBeforeBubbleInsertion");
        SpeedShotBubble = PlayerPrefs.GetInt("SpeedShotBubble");
        Volum = PlayerPrefs.GetInt("Volum");

        for (int i = 0; i < CountOfBubbleColor; i++)
        {
            SelectedBubbleColor.Add(ColorDico[PlayerPrefs.GetString("Color" + (i + 1).ToString())]);
        }
        SelectedarrowColor = arrowColorDico[PlayerPrefs.GetString("ArrowColor")];
    }

    public bool firstInit()
    {
        if (PlayerPrefs.GetString("Color1") != null)
        {
            return false;
        }
        else
        {
            PlayerPrefs.SetString("BubbleColor1", "Blue");
            PlayerPrefs.SetString("BubbleColor2", "Red");
            PlayerPrefs.SetString("BubbleColor3", "Cyan");
            PlayerPrefs.SetString("BubbleColor4", "Yellow");
            PlayerPrefs.SetString("BubbleColor5", "Fuchsia");
            PlayerPrefs.SetString("BubbleColor6", "Lime");

            PlayerPrefs.SetString("ArrowColor", "Astral");

            PlayerPrefs.SetInt("CountOfBubbleColor", 6);
            PlayerPrefs.SetInt("CountOfBubbleRow", 15);
            PlayerPrefs.SetInt("CountOfBubbleColumn", 17);
            PlayerPrefs.SetInt("CountOfBubbleToExplode", 3);


            PlayerPrefs.SetString("Difficulty", "easy");
            PlayerPrefs.SetString("SelectedSpeed", "low");
            PlayerPrefs.SetInt("CountOfShotBeforeBubbleInsertion", 10);
            PlayerPrefs.SetInt("SpeedShotBubble", 80);
            PlayerPrefs.SetInt("Volum", 5);

            return true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
