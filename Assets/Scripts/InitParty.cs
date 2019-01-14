using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitParty : MonoBehaviour
{
    public static Bubble[][] InitBoard;
    Bubble CurrentBubble;
    Bubble NextBubble;
    // Start is called before the first frame update
    void Start()
    {
        initBoard();
    }

    private Bubble getRandomBubble()
    {
        string rdnstr = "";
        //getrdn HEX from color
        System.Random r = new System.Random();
        int rInt = r.Next(1, InitGame.CountOfBubbleColor + 1); //for ints       
        Color color = InitGame.ColorDico[PlayerPrefs.GetString("Color" + (rInt).ToString())];
        ColorUtility.TryParseHtmlString(rdnstr, out color);
        Bubble bubble = new Bubble(color);
        return bubble;
    }

    private void initBoard()
    {
        InitBoard = new Bubble[InitGame.CountOfBubbleRow][];
        for(int i = 0;i < InitGame.CountOfBubbleRow; i++){
            InitBoard[i] = new Bubble[InitGame.CountOfBubbleColumn];
            for (int j = 0; j < InitGame.CountOfBubbleColumn; j++)
            {
                InitBoard[i][j] = getRandomBubble();
                //Initboard[i][j].position = (i, j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}