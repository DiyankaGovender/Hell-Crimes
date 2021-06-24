using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Envelope : MonoBehaviour
{
    private Vector2 startpos;

    public GameObject letter_scene;

    public bool letterisOnCraftingSlot1;
    public bool letterisOnCraftingSlot2;

    public BoxCollider2D clock_boxcollider;
    public BoxCollider2D skeleton_boxcollider;
    public BoxCollider2D painting_boxcollider;
    public BoxCollider2D bookshelf_boxcollider;
    public BoxCollider2D wall_boxcollider;
    public BoxCollider2D couch_boxcollider;
    public BoxCollider2D board_boxcollider;
    public BoxCollider2D chest_boxcollider;

    void Start()
    {
        letterisOnCraftingSlot1 = false;
        letterisOnCraftingSlot2 = false;

        startpos = transform.position;
    }


    void Update()
    {


    }

    public void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(1))
        {
            letter_scene.SetActive(true);
            Debug.Log("right");

            if (letter_scene.activeInHierarchy)
            {
                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;
            }
        }

    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Crafting_1")
        {
            letterisOnCraftingSlot1 = true;
            letterisOnCraftingSlot2 = false;
            Debug.Log("letter_slot1");
        }

        if (collision.gameObject.name == "Crafting_2")
        {
            letterisOnCraftingSlot1 = false;
            letterisOnCraftingSlot2 = true;
            Debug.Log("letter_slot2");
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        letterisOnCraftingSlot1 = false;
        letterisOnCraftingSlot2 = false;
    }

    public void resetpos()
    {
        transform.position = startpos;
    }

}
