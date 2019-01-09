using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefullScrit : MonoBehaviour
{
    public Color[][] GameBoard { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        GameBoard = InitParty.Initboard;
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

    private bool isBubbleMaintain(int i, int j)
    {

        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
