using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class Rook : Figure
    {
        public Rook(Coordinate currentСoordinates, Rotate rotate, List<Coordinate> avaibleCoordinates, string color)
        {
            this.currentСoordinates = currentСoordinates;
            this.rotate = rotate;
            this.avaibleCoordinates = avaibleCoordinates;
            this.color = color;
        }

    }
}