using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class Queen : Figure
    {
        public Queen(Coordinate currentСoordinates, Rotate rotate, List<Coordinate> avaibleCoordinates, string color)
        {
            this.currentСoordinates = currentСoordinates;
            this.rotate = rotate;
            this.avaibleCoordinates = avaibleCoordinates;
            this.color = color;
        }

    }
}