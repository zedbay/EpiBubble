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

   

    private void UpdateSelectedColors()
    {
        SelectedBubbleColors.Clear();
        //PlayerPrefs.SetString("Color1", "");  
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateSelectedColors();
    }
}
