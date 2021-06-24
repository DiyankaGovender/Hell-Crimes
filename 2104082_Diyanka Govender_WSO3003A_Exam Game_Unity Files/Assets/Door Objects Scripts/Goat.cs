using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat : MonoBehaviour
{
    public bool goatisOnGreenCircle;
    public GameObject drawingMoveable;
    public GameObject drawingSprite;
    void Start()
    {
        goatisOnGreenCircle = false;
        drawingSprite.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green")
        {
            drawingMoveable.SetActive(false);
            drawingSprite.SetActive(true);
            goatisOnGreenCircle = true;
            Debug.Log("Green");
        }
    }
}
