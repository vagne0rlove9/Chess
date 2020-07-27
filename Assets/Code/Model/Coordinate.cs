using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class Coordinate
    {
        public Coordinate(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float x;
        public float y;
        public float z;
    }
}