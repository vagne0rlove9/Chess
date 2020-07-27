using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Model;

namespace Model
{
    public class RepoBlackFigure : RepoFigure
    {
        public RepoBlackFigure(List<Figure> figures)
        {
            this.figures = figures;
        }

        public RepoBlackFigure() { }
    }
}