using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FigureScript : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Bishop!");
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
        pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        transform.position = new Vector3(pos_move.x, 0.5f, pos_move.z);
        Debug.Log(transform.position);
    }

   /* private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.gameObject.GetComponent<Rigidbody>();
        if (rigidbody != null) {
            rigidbody.AddForce(hit.moveDirection * 10f);
        }
    }
    */

    private void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.transform.position = transform.position + new Vector3(Input.mousePosition.x, 0.5f, Input.mousePosition.z);
    }

}
