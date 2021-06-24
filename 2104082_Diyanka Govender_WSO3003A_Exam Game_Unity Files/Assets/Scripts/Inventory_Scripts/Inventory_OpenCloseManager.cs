using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_OpenCloseManager : MonoBehaviour
{
    public GameObject inventory_scene;
    public Object_Dialogue_Script object_Dialogue_Script;

    public BoxCollider2D clock_boxcollider;
    public BoxCollider2D skeleton_boxcollider;
    public BoxCollider2D painting_boxcollider;
    public BoxCollider2D bookshelf_boxcollider;
    public BoxCollider2D wall_boxcollider;
    public BoxCollider2D couch_boxcollider;
    public BoxCollider2D board_boxcollider;
    public BoxCollider2D chest_boxcollider;



    //LETTER ON PAINTING
    public GameObject letterEnvelopeOnPainting;

    //BOOKS ON BOOKSHELF 
    public GameObject Incorrect_RomeoJuliette;
    public GameObject Incorrect_HarryPotter;
    public GameObject Incorrect_EatPrayWitch;
    public GameObject Incorrect_Hamlet;
    public GameObject Correct_Book;


    //CLOCK SCENE GAMEOBJECTS
    public GameObject clock1;
    public GameObject clock2;
    public GameObject clock3;
    public GameObject clock4;
    public GameObject clock5;
    public GameObject clock7;
    public GameObject clock8;
    public GameObject clock9;
    public GameObject clock10;
    public GameObject clock11;
    public GameObject clock12;

    public GameObject Number666Object;

   


    //SKELETON SCENE GAMEOBJECTS 
    public GameObject skull_1;
    public GameObject skull_2;

    public GameObject skull_object;




    //WRITING WALL SCENE 
    public GameObject hipppie_writng;
    public GameObject communism_writing;
    public GameObject anarchy_writing;
    public GameObject ankh_writing;
    public GameObject eye_writing;
    public GameObject power_writing;

    public GameObject pentagram_object;


    //COUCH SCENE
    public GameObject birthday_card;
    public GameObject fool_card;
    public GameObject moon_card;
    public GameObject tower_card;
    public GameObject two_card;

    public GameObject tarot_object;




    //CHEST SCENE GAMEOBJECTS
    public GameObject moo_vial;
    public GameObject woof_vial;
    public GameObject oink_vial;
    public GameObject meow_vial;

    public GameObject goatblood_object;



    //BOARD SCENE GAMEOBJECTS 
    public GameObject girl1;
    public GameObject girl2;
    public GameObject girl3;
    public GameObject girl4;
    public GameObject girl5;
    public GameObject girl6;
    public GameObject girl7;

    public GameObject drawing_object;

    public GameObject main_scenefllylit;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (inventory_scene.activeInHierarchy==true )
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
