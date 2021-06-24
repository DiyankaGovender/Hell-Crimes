using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Zoomed_In_Scenes_Clicker : MonoBehaviour
{
    public GameObject scene_textbox;
  
    public Dialouge_Script dialouge_Script;
    public Object_Dialogue_Script object_Dialogue_Script;

    public GameObject clock_scene;
    public GameObject skeleton_scene;
    public GameObject painting_scene;
    public GameObject bookshelf_scene;
    public GameObject wall_scene;
    public GameObject couch_scene;
    public GameObject board_scene;
    public GameObject chest_scene;



    public BoxCollider2D clock_boxcollider;
    public BoxCollider2D skeleton_boxcollider;
    public BoxCollider2D painting_boxcollider;
    public BoxCollider2D bookshelf_boxcollider;
    public BoxCollider2D wall_boxcollider;
    public BoxCollider2D couch_boxcollider;
    public BoxCollider2D board_boxcollider;
    public BoxCollider2D chest_boxcollider;

    

    public void Start()
    {
       

    }

    public void Update()
    {
       
    }

    public void OnMouseDown()
    {
       if(Input.GetMouseButtonDown(0))
        {


            if (Input.GetMouseButtonDown(0) && gameObject.tag == "Clock")
            {
                clock_scene.SetActive(true);
               

                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled=false;
                painting_boxcollider.enabled =false;
                bookshelf_boxcollider.enabled=false;
                wall_boxcollider.enabled =false;
                couch_boxcollider.enabled=false;
                board_boxcollider.enabled=false;
                chest_boxcollider.enabled=false;

                object_Dialogue_Script.clickedonclockscene();
               
             }
           

            if (gameObject.tag == "Skeleton" )
            {
                skeleton_scene.SetActive(true);


                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;

                object_Dialogue_Script.clickedonskeletonscene();
            }

            if (Input.GetMouseButtonDown(0) && gameObject.tag == "Painting")
            {
                scene_textbox.SetActive(false);
                Debug.Log("help");
                painting_scene.SetActive(true);



                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;

              
                
                
            }

            if (gameObject.tag == "Couch")
            {
                couch_scene.SetActive(true);



                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;

                object_Dialogue_Script.clickedoncouchscene();
            }

            if (gameObject.tag == "Chest")
            {
                chest_scene.SetActive(true);


                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;

                object_Dialogue_Script.clickedonchestscene();
            }

            if (gameObject.tag == "Wall")
            {
                wall_scene.SetActive(true);


                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;

                object_Dialogue_Script.clickedonwritingscene();
            }

            if (gameObject.tag == "Bookshelf")
            {
                bookshelf_scene.SetActive(true);


                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;

            }

            if (gameObject.tag == "Board")
            {
                board_scene.SetActive(true);


                clock_boxcollider.enabled = false;
                skeleton_boxcollider.enabled = false;
                painting_boxcollider.enabled = false;
                bookshelf_boxcollider.enabled = false;
                wall_boxcollider.enabled = false;
                couch_boxcollider.enabled = false;
                board_boxcollider.enabled = false;
                chest_boxcollider.enabled = false;

                object_Dialogue_Script.clickedonboardscene();
            }
        }
    }
}
