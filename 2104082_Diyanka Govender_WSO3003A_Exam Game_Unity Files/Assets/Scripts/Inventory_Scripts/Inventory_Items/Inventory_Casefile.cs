using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Casefile : MonoBehaviour
{
    private Vector2 startpos;

    public GameObject casefile_scene;

    public bool caseFileisOnCraftingSlot1;
    public bool caseFileisOnCraftingSlot2;

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
        caseFileisOnCraftingSlot1 = false;
        caseFileisOnCraftingSlot2 = false;

        startpos = transform.position;
    }

  
    void Update()
    {
       

    }

    public void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            casefile_scene.SetActive(true);
            if (casefile_scene.activeInHierarchy)
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
                caseFileisOnCraftingSlot1 = true;
                caseFileisOnCraftingSlot2 = false;
                Debug.Log("casefile_slot1");
            }

            if (collision.gameObject.name == "Crafting_2")
            {
                caseFileisOnCraftingSlot1 = false;
                caseFileisOnCraftingSlot2 = true;
                Debug.Log("casefile_slot2");
            }
        
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        caseFileisOnCraftingSlot1 = false;
        caseFileisOnCraftingSlot2 = false;
    }

    public void resetpos()
    {
        transform.position = startpos;
    }

}
