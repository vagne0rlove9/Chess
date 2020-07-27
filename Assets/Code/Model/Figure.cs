using UnityEngine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace Model
{
    abstract public class Figure : INotifyPropertyChanged
    {
        public Coordinate currentСoordinates = new Coordinate(0, 0, 0);
        public Rotate rotate = new Rotate(0, 0, 0);
        public List<Coordinate> avaibleCoordinates = new List<Coordinate>();
        public string color;

        public event PropertyChangedEventHandler PropertyChanged;
 
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        //TODO animation and object
    }
}