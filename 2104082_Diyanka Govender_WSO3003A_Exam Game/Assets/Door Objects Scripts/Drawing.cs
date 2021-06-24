using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public bool drawingisOnPurpleCircle;
    public GameObject drawingMoveable;
    public GameObject drawingSprite;
    void Start()
    {
        drawingisOnPurpleCircle = false;
        drawingSprite.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Purple")
        {
            drawingMoveable.SetActive(false);
            drawingSprite.SetActive(true);
            drawingisOnPurpleCircle= true;
            Debug.Log("Purple");
        }
    }
}
