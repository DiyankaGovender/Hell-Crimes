using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarot_Card : MonoBehaviour
{
    public bool tarotCardisOnBlueCircle;
    public GameObject tarotCardMoveable;
    public GameObject tarotcardSprite;
    void Start()
    {
        tarotCardisOnBlueCircle = false;
        tarotcardSprite.SetActive(false);
    }
  void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag=="Blue")
        {
            tarotCardMoveable.SetActive(false);
            tarotcardSprite.SetActive(true);
            tarotCardisOnBlueCircle = true;
            Debug.Log("Blue");
        }
    }


}
