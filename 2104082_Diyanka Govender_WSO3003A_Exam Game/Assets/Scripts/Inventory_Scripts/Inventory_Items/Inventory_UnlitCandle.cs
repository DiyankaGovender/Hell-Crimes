using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_UnlitCandle : MonoBehaviour
{

    private Vector2 startpos;

    public bool candleisOnCraftingSlot1;
    public bool candleisOnCraftingSlot2;
    void Start()
    {
        candleisOnCraftingSlot1 = false;
        candleisOnCraftingSlot2 = false;

        startpos = transform.position;
    }


    void Update()
    {
       

    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Crafting_1")
        {
            candleisOnCraftingSlot1 = true;
            candleisOnCraftingSlot2 = false;
            Debug.Log("unlitcandle_slot1");
        }

        if (collision.gameObject.name == "Crafting_2")
        {
            candleisOnCraftingSlot1 = false;
            candleisOnCraftingSlot2 = true;
            Debug.Log("unlitcandle_slot2");
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        candleisOnCraftingSlot1 = false;
        candleisOnCraftingSlot2 = false;
    }
    public void resetpos()
    {
        transform.position = startpos;
    }
}
