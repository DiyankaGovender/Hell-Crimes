using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_BlankPaper : MonoBehaviour
{
    private Vector2 startpos;

    public GameObject blankpaper_scene;

    public bool blankpaperisOnCraftingSlot1;
    public bool blankpaperisOnCraftingSlot2;

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
        blankpaperisOnCraftingSlot1 = false;
        blankpaperisOnCraftingSlot2 = false;

        startpos = transform.position;

    }


    public void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(1))
        {
            blankpaper_scene.SetActive(true);
            if (blankpaper_scene.activeInHierarchy)
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
            blankpaperisOnCraftingSlot1 = true;
            blankpaperisOnCraftingSlot2 = false;
            Debug.Log("casefile_slot1");
        }

        if (collision.gameObject.name == "Crafting_2")
        {
            blankpaperisOnCraftingSlot1 = false;
            blankpaperisOnCraftingSlot2 = true;
            Debug.Log("casefile_slot2");
        }


    }

    public void resetpos()
    {
        transform.position = startpos;
    }
}
