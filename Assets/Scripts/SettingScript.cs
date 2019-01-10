using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScript : MonoBehaviour
{
    public List<Color> SelectedBubbleColors;

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
    }

    // Update is called once per frame
    void Update()
    {
        //put all
    }
}
