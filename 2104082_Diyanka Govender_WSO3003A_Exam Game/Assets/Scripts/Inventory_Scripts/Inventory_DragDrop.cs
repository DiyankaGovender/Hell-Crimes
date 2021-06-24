using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_DragDrop : MonoBehaviour
{
    private bool isDragging;




    public void Start()
    {



    }
    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }
       
    }

    public void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    void Update()
    {
        if (isDragging == true)
        {
            Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mouseposition);

        }




    }
}
