using System;
using UnityEngine;

namespace Application
{
    public class Emplacement 
    {
        public int x;
        public int y;
        public bool isFree;
        public GameObject bulle;

        public Emplacement(int x, int y, GameObject bulle)
        {
            this.x = x;
            this.y = y;
            this.isFree = false;
            this.bulle = bulle;
        }
    }
}
