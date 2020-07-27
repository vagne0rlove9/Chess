using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class FactoryAbstract
    {
        public FactoryAbstract() { }

        public Coordinate centerSzene = new Coordinate(0.25f, 10.75f, 0f);
        public virtual RepoFigure createFigures(List<GameObject> gameObjects) { return new RepoFigure(); }
    }
}