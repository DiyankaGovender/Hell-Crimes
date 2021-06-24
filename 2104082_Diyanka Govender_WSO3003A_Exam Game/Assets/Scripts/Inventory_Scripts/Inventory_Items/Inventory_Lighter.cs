using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Lighter : MonoBehaviour
{

    private Vector2 startpos;
    public bool lighterisOnCraftingSlot1;
    public bool lighterisOnCraftingSlot2;
    void Start()
    {
        lighterisOnCraftingSlot1 = false;
        lighterisOnCraftingSlot2 = false;

        startpos = transform.position;
    }


    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Crafting_1")
        {
            lighterisOnCraftingSlot1 = true;
            lighterisOnCraftingSlot2 = false;
            Debug.Log("lighter_slot1");
        }

        if (collision.gameObject.name == "Crafting_2")
        {
            lighterisOnCraftingSlot1 = false;
            lighterisOnCraftingSlot2 = true;
            Debug.Log("lighter_slot2");
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        lighterisOnCraftingSlot1 = false;
        lighterisOnCraftingSlot2 = false;
    }

    public void ResetPos()
    {
        transform.position = startpos;
    }


}
