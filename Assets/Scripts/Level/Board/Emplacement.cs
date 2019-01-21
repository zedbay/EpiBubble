using System;
using UnityEngine;

namespace Application
{
    public class Emplacement 
    {
        public int x;
        public int y;
        public GameObject bulle;

        public Emplacement(int x, int y, GameObject bulle)
        {
            this.x = x;
            this.y = y;
            this.bulle = bulle;
            Debug.Log(bulle);
        }
    }
}
