using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefullScrit : MonoBehaviour
{
    public Bubble[][] GameBoard { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        GameBoard = InitParty.InitBoard;
    }

    public bool bubbleFalling()
    {
        bool done = false;
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; i < 17; j++)
            {
                if (!isBubbleMaintain(i, j))
                {
                    //make bubble fall
                }
            }
            if(i == 14)
            {
                done = true;
            }
        }
        return done;
    }

    public int[] CloseBubblelist(int i , int j)
    {
        int[] toTest = new int[] { i + 1, i - 1, i - 17, i + 17 };
        if (i == 0 || i % 2 == 0)
        {
            toTest[4] = i - 17 + 1;
            toTest[5] = i + 17 + 1;
        }
        else
        {
            toTest[4] = i - 17 - 1;
            toTest[5] = i + 17 - 1;
        }
        return toTest;
    } 

    private bool isBubbleMaintain(int i, int j)
    {
        
        int[] toTest = CloseBubblelist(i, j);
        for(int k = 0; k < toTest.Length; k++)
        {
            if(GameBoard[i/17][i%17] != null)
            {
                return true;
            }
        }
        //test each cell
        return false;
    }

    private Color getRandomBubble()
    {
        string rdnstr ="";
        //getrdn HEX from color
        System.Random r = new System.Random();
        int rInt = r.Next(1, InitGame.CountOfBubbleColor+1); //for ints       
        Color color = InitGame.ColorDico[PlayerPrefs.GetString("Color" + (rInt).ToString())];
       //ColorUtility.TryParseHtmlString(rdnstr,out color);

        return color;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
