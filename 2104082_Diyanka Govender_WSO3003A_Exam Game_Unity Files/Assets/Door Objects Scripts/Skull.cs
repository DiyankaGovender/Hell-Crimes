using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    public bool skullCardisOnYelllowCircle;
    public GameObject skullMoveable;
    public GameObject skullSprite;
    void Start()
    {
        skullCardisOnYelllowCircle = false;
        skullSprite.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Yellow")
        {
            skullCardisOnYelllowCircle = true;
            skullMoveable.SetActive(false);
            skullSprite.SetActive(true);
            Debug.Log("Yellow");
        }
    }

  
}
