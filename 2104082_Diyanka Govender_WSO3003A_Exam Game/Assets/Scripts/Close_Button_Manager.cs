using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_Button_Manager : MonoBehaviour
{
    //LETTER INVENTORY OBJECT
    public GameObject letter_inventory;
    //
 

    public GameObject clock_scene;
    public GameObject painting_scene;
    public GameObject bookshelf_scene;
    public GameObject skeleton_scene;
    public GameObject writingwall_scene;
    public GameObject couch_scene;
    public GameObject board_scene;
    public GameObject chest_scene;
    public GameObject inventorycrafting_scene;
    public GameObject crimefile_scene;
    public GameObject letter_scene;
    public GameObject blankpaper_scene;
    public GameObject cluesheet_scene;
    

    public BoxCollider2D clock_boxcollider;
    public BoxCollider2D skeleton_boxcollider;
    public BoxCollider2D painting_boxcollider;
    public BoxCollider2D bookshelf_boxcollider;
    public BoxCollider2D wall_boxcollider;
    public BoxCollider2D couch_boxcollider;
    public BoxCollider2D board_boxcollider;
    public BoxCollider2D chest_boxcollider;
    public BoxCollider2D cluesheet_boxcollider;
    public void Start()
    {
        
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(gameObject.name == "Clock_Close")
            {
                clock_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;

            }

            if (gameObject.name == "Painting_Close")
            {
                painting_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name=="Bookshelf_Close")
            {
                bookshelf_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "Skeleton_Close")
            {
                skeleton_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "WritingWall_Close")
            {
                writingwall_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "Couch_Close")
            {
                couch_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "Board_Close")
            {
                board_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "Chest_Close")
            {
                chest_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if(gameObject.name== "Inventory+Crafting_Close")
            {
                inventorycrafting_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;


            }

            if(gameObject.name== "CrimeFile_Close")
            {
                crimefile_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "Letter_Close")
            {
                letter_scene.SetActive(false);

               
                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "BlankPaper_Close")
            {
                blankpaper_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }

            if (gameObject.name == "ClueSheet_Close")
            {
                cluesheet_scene.SetActive(false);

                clock_boxcollider.enabled = true;
                skeleton_boxcollider.enabled = true;
                painting_boxcollider.enabled = true;
                bookshelf_boxcollider.enabled = true;
                wall_boxcollider.enabled = true;
                couch_boxcollider.enabled = true;
                board_boxcollider.enabled = true;
                chest_boxcollider.enabled = true;
            }
        }
        
    }
}
