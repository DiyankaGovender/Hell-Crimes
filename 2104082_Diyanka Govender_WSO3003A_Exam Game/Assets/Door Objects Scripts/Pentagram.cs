using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagram : MonoBehaviour
{

    public bool pentagramisOnRedCircle;
    public GameObject drawingMoveable;
    public GameObject drawingSprite;
    void Start()
    {
        pentagramisOnRedCircle = false;
        drawingSprite.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            drawingMoveable.SetActive(false);
            drawingSprite.SetActive(true);
            pentagramisOnRedCircle = true;
            Debug.Log("Red");
        }
    }
}
