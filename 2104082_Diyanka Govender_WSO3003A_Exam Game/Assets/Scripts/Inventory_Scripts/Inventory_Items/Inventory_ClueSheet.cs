using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_ClueSheet : MonoBehaviour
{
    public BoxCollider2D clock_boxcollider;
    public BoxCollider2D skeleton_boxcollider;
    public BoxCollider2D painting_boxcollider;
    public BoxCollider2D bookshelf_boxcollider;
    public BoxCollider2D wall_boxcollider;
    public BoxCollider2D couch_boxcollider;
    public BoxCollider2D board_boxcollider;
    public BoxCollider2D chest_boxcollider;

    public GameObject cluesheet_scene;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(1))
        {
            cluesheet_scene.SetActive(true);
            if (cluesheet_scene.activeInHierarchy)
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

}
