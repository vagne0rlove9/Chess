using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Model;

public class Render : MonoBehaviour
{
    public Render() { }

    public static void instantiate(List<GameObject> gameObjects, List<Figure> figures)
    {
        for (int i = 0; i < gameObjects.Count; i++)
        {
            GameObject go = Instantiate(gameObjects[i], new Vector3(figures[i].currentСoordinates.x, figures[i].currentСoordinates.y, figures[i].currentСoordinates.z), Quaternion.identity) as GameObject;
            go.transform.Rotate(figures[i].rotate.x, figures[i].rotate.y, figures[i].rotate.z);
            //go.transform.Rotate(-90f, 0f, 0f);
            go.transform.parent = GameObject.Find("GameObject").transform;            
        }     
    }
}
