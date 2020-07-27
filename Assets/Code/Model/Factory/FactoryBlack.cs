﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class FactoryBlack : FactoryAbstract
    {
        public FactoryBlack()
        {
        }

        public override RepoFigure createFigures(List<GameObject> gameObjects)
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Pawn(new Coordinate(centerSzene.x - 8, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки
            figures.Add(new Pawn(new Coordinate(centerSzene.x - 6, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки
            figures.Add(new Pawn(new Coordinate(centerSzene.x - 4, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки
            figures.Add(new Pawn(new Coordinate(centerSzene.x - 2, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки
            figures.Add(new Pawn(new Coordinate(centerSzene.x - 0, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки
            figures.Add(new Pawn(new Coordinate(centerSzene.x + 2, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки
            figures.Add(new Pawn(new Coordinate(centerSzene.x + 4, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки
            figures.Add(new Pawn(new Coordinate(centerSzene.x + 6, centerSzene.y, centerSzene.z - 2), new Rotate(0f, 0f, 0f), new List<Coordinate>(), "Black")); //пешки

            figures.Add(new Rook(new Coordinate(centerSzene.x - 8, centerSzene.y - 3.5f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // ладья
            figures.Add(new Rook(new Coordinate(centerSzene.x + 6, centerSzene.y - 3.5f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // ладья
            figures.Add(new Knight(new Coordinate(centerSzene.x - 6, centerSzene.y - 3.5f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // конь
            figures.Add(new Knight(new Coordinate(centerSzene.x + 4, centerSzene.y - 3.5f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // конь
            figures.Add(new Bishop(new Coordinate(centerSzene.x - 4, centerSzene.y - 3.0f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // слон
            figures.Add(new Bishop(new Coordinate(centerSzene.x + 2, centerSzene.y - 3.0f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // слон
            figures.Add(new King(new Coordinate(centerSzene.x - 2, centerSzene.y - 3.25f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // король
            figures.Add(new Queen(new Coordinate(centerSzene.x + 0, centerSzene.y - 3.25f, centerSzene.z - 0), new Rotate(-90f, 0f, 0f), new List<Coordinate>(), "Black")); // королева

            Render.instantiate(gameObjects, figures);
            
            return new RepoBlackFigure(figures);
        }
    }
}
