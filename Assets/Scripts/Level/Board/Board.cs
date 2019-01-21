using System;
using System.Collections.Generic;
using UnityEngine;

namespace Application
{
    public class Board 
    {
        public List<Emplacement> tabBoard = new List<Emplacement>();

        public Board()
        {
           
        }

        public Emplacement GetEmplacement(int x, int y)
        {

            for (int i = 0; i < tabBoard.Count; i++)
            {
                if ((tabBoard[i].x == x) && (tabBoard[i].y == y))
                {
                    return tabBoard[i];
                }
                    
            }
            return null;
        }

        public void SetEmplacement(int x, int y, GameObject bulle)
        {
            Emplacement tmp = new Emplacement(x, y, bulle);
            tabBoard.Add(tmp);
        }

        public void RemoveEmplacement(int x, int y)
        {
            for (int i = 0; i < tabBoard.Count; i++)
            {
                Debug.Log("On recherche" + x + " : " + y);
                if ((tabBoard[i].x == x) && (tabBoard[i].y == y))
                {
                    tabBoard.RemoveAt(i);
                }
            }
        }
    }
}
