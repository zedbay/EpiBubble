using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    Color color;
    (int, int) position;
    bool launchable;
    int NbrRow = PlayerPrefs.GetInt("CountOfRow");
    int NbrColumn = PlayerPrefs.GetInt("CountOfColumn");

    public Bubble(Color color)
    {
        this.color = color;
    }

    // Start is called before the first frame update
    void Start()
    {
        //get random color
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool bubbleFalling()
    {
        bool done = false;
        for (int i = 0; i < NbrRow; i++)
        {
            for (int j = 0; i < NbrColumn; j++)
            {
                if (!isBubbleMaintain(i, j))
                {
                    //make bubble fall
                }
            }
            if (i == 14)
            {
                done = true;
            }
        }
        return done;
    }

    public int[] CloseBubblelist(int i, int j)
    {
        int[] toTest = new int[] { i + 1, i - 1, i - NbrColumn, i + NbrColumn };
        if (i == 0 || i % 2 == 0)
        {
            toTest[4] = i - NbrColumn + 1;
            toTest[5] = i + NbrColumn + 1;
        }
        else
        {
            toTest[4] = i - NbrColumn - 1;
            toTest[5] = i + NbrColumn - 1;
        }
        return toTest;
    }

    private bool isBubbleMaintain(int i, int j)
    {

        int[] toTest = CloseBubblelist(i, j);
        for (int k = 0; k < toTest.Length; k++)
        {
            if (InitParty.InitBoard[i / NbrColumn][i % NbrColumn] != null)
            {
                return true;
            }
        }
        return false;
    }
}
