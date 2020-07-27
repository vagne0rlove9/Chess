using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BishopScript : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Bishop!");
    }

    // Start is called before the first frame update
    void Start()
    {

    }    

    // Update is called once per frame
    void Update()
    {

    }

    float distance_to_screen;
    Vector3 pos_move;
 
    void OnMouseDrag()
    {
        distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y + 4f, distance_to_screen));
        transform.position = new Vector3(pos_move.x + 2.9f, 4.75f, pos_move.z - 5f);
        Debug.Log(transform.position);
    }

}
