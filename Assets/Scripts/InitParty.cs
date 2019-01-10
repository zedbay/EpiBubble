using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitParty : MonoBehaviour
{
    public static Color[][] Initboard;
    // Start is called before the first frame update
    //Bubble+CurrentBubble
    void Start()
    {
        initBoard();
    }

    private void initBoard()
    {
        Initboard = new Color[15][];
        for(int i = 0;i < 15;i++){
            Initboard[i] = new Color[17];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}