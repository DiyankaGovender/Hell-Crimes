using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_LitCandle : MonoBehaviour
{
    private Vector2 startpos;
    public bool litcandleisOnCraftingSlot1;
    public bool litcandleisOnCraftingSlot2;

    void Start()
    {
        litcandleisOnCraftingSlot1 = false;
        litcandleisOnCraftingSlot2 = false;

        startpos = transform.position;
    }

 
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Crafting_1")
        {
            litcandleisOnCraftingSlot1 = true;
            litcandleisOnCraftingSlot2= false;
            Debug.Log("litcandle_slot1");
        }

        if (collision.gameObject.name == "Crafting_2")
        {
            litcandleisOnCraftingSlot1 = false;
            litcandleisOnCraftingSlot2 = true;
            Debug.Log("litcandle_slot2");
        }


    }

     void OnTriggerExit2D(Collider2D collision)
    {

        litcandleisOnCraftingSlot1 = false;
        litcandleisOnCraftingSlot2 = false;
    }
    public void ResetPos()
    {
        transform.position = startpos;
    }

}
