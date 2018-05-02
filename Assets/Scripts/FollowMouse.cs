using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    GameObject Dragging = null;

    public GameManager gameManager;
    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButton(0) && Dragging != null)
        {

            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 pos = Dragging.transform.position;
            pos += (mousePosition - pos) * 0.9f;
            pos.z = 10;
            Dragging.transform.position = pos;
            Dragging.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (Input.GetMouseButtonUp(0) && Dragging != null)
        {
            Dragging.GetComponent<BoxCollider2D>().enabled = true;
            Dragging = null;
        }


    }
    public void SetDraggingObject(GameObject obj)
    {
        Dragging = obj;
    }
}
