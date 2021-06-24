using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{

    public bool numberisOnOrangeCircle;
    public GameObject numberMoveable;
    public GameObject numberSprite;
    void Start()
    {
        numberisOnOrangeCircle = false;
        numberSprite.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Orange")
        {
            numberMoveable.SetActive(false);
            numberSprite.SetActive(true);
            Debug.Log("Orange");
            numberisOnOrangeCircle = true;
        }
    }

 
}
