using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Manager : MonoBehaviour
{
    //SCRIPTS 
    public Object_Dialogue_Script Object_Dialogue_Script;
    public Crafting_Checker crafting_Checker;
    public Cluesheet_Manager cluesheet_Manager;
    public IncorrectObjects_Manager incorrectObjects_Manager;

    //GAME OBJECTS
    //LETTER ON PAINTING
    public GameObject letterEnvelopeOnPainting;

    //BOOKS ON BOOKSHELF 
    public GameObject Incorrect_RomeoJuliette;
    public GameObject Incorrect_HarryPotter;
    public GameObject Incorrect_EatPrayWitch;
    public GameObject Incorrect_Hamlet;
    public GameObject Correct_Book;
    public GameObject bookshelf_boxcollider;
    public GameObject painting_boxcollider;

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

    public GameObject clock_boxcollider;


    //SKELETON SCENE GAMEOBJECTS 
    public GameObject skull_1;
    public GameObject skull_2;

    public GameObject skull_object;

    public GameObject skull_boxcollider;


    //WRITING WALL SCENE 
    public GameObject hipppie_writng;
    public GameObject communism_writing;
    public GameObject anarchy_writing;
    public GameObject ankh_writing;
    public GameObject eye_writing;
    public GameObject power_writing;

    public GameObject pentagram_object;

    public GameObject writing_boxcollider;

    //COUCH SCENE
    public GameObject birthday_card;
    public GameObject fool_card;
    public GameObject moon_card;
    public GameObject tower_card;
    public GameObject two_card;

    public GameObject tarot_object;

    public GameObject couch_boxcolider;



    //CHEST SCENE GAMEOBJECTS
    public GameObject moo_vial;
    public GameObject woof_vial;
    public GameObject oink_vial;
    public GameObject meow_vial;

    public GameObject goatblood_object;

    public GameObject chest_boxcollider;

    //BOARD SCENE GAMEOBJECTS 
    public GameObject girl1;
    public GameObject girl2;
    public GameObject girl3;
    public GameObject girl4;
    public GameObject girl5;
    public GameObject girl6;
    public GameObject girl7;

    public GameObject drawing_object;

    public GameObject board_boxcollider;

    public void OnMouseDown()
    {

        //PAINTING AND BOOKSHELF SCENES 
        {
            //CLICKING ON PAINTING 
            if (Input.GetMouseButtonDown(0) && gameObject.tag == "Painting")
            {
                Object_Dialogue_Script.clickedonpainting();
            }

            //CLICKED ON ENVELOPE ON PAINTING
            if (Input.GetMouseButtonDown(0) && gameObject.name == "Letter_Envelope_onPainting" )
            {
                letterEnvelopeOnPainting.SetActive(false);
                painting_boxcollider.SetActive(false);
                Object_Dialogue_Script.clickedonenvelopeonpainting();
            }

            //CLICKED ON BOOKSHELF
            if (Input.GetMouseButtonDown(0) && gameObject.name == "Bookshelf_BoxCollider")
            {
                Object_Dialogue_Script.clickedonbookshelf();
            }

            //CLICKED ON INCORRECT BOOK ROMEO+JULIETTE
            if (Input.GetMouseButtonDown(0) && gameObject.name == "Incorrect_Romeo+Juliette")
            {
                Object_Dialogue_Script.clickedonromeonandjuliette();
                Incorrect_RomeoJuliette.SetActive(false);
            }
            //CLICKED ON INCORRECT BOOK HAMLET 
            if (Input.GetMouseButtonDown(0) && gameObject.name == "Incorrect_Hamlet")
            {
                Object_Dialogue_Script.clickedonhamlet();
                Incorrect_Hamlet.SetActive(false);
            }

            //CLICKED ON INCORRECT HARRY POTTER
            if (Input.GetMouseButtonDown(0) && gameObject.name == "Incorrect_HarryPotter")
            {
                Object_Dialogue_Script.clickedonharrypotter();
                Incorrect_HarryPotter.SetActive(false);
            }

            //CLICKED ON INCORRECT EAT WITCH LOVE 
            if (Input.GetMouseButtonDown(0) && gameObject.name == "Incorrect_EatPrayWitch")
            {
                Object_Dialogue_Script.clickedoneatwitchlove();
                Incorrect_EatPrayWitch.SetActive(false);
            }

            //CLICKED ON CORRECT BOOK MACBETH
            if (Input.GetMouseButtonDown(0) && gameObject.name == "Correct_Book")
            {
                Object_Dialogue_Script.clickedoncorrectbook();
                Correct_Book.SetActive(false);
                bookshelf_boxcollider.SetActive(false);
                crafting_Checker.blankpaperactive();
            }

        }






        //SKELETON SCENE
        //CLICKED ON SKULL OBJECT
        if (Input.GetMouseButton(0) && gameObject.name == "Skull_Object" && gameObject.tag == "Correct_Object")
        {
            Object_Dialogue_Script.clickedonskullobject();

            skull_object.SetActive(false);
            skull_boxcollider.SetActive(false);
            cluesheet_Manager.foundSkullobject();
        }

        //CLICKED ON INCORRECT SKULL 1
        if (Input.GetMouseButton(0) && gameObject.name == "Skull_1")
        {
            Object_Dialogue_Script.clickedonincorrectskull1();

            skull_1.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }
        //CLICKED ON INCORRECT SKULL 2
        if (Input.GetMouseButton(0) && gameObject.name == "Skull_2")
        {
            Object_Dialogue_Script.clickedonincorrectskull2();

            skull_2.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }






        //CLOCK SCENCE

        //CLICKED ON 666 OBJECT 
        if (Input.GetMouseButtonDown(0) && gameObject.name == "666_Object" && gameObject.tag == "Correct_Object")
        {
            Number666Object.SetActive(false);
            Object_Dialogue_Script.clickedon666object();
            clock_boxcollider.SetActive(false);
            cluesheet_Manager.found666object();
        }

        //CLOCK SCENE INCORRECT NUMBERS 
        if (Input.GetMouseButtonDown(0) && gameObject.name == "1" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects();

            clock1.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "2" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects2();

            clock2.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "3" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects();

            clock3.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "4" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects2();

            clock4.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "5" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects();

            clock5.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "7" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects2();

            clock7.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "8" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects();

            clock8.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "9" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects2();

            clock9.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "10" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects();

            clock10.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "11" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects2();

            clock11.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "12" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrectclockobjects();

            clock12.SetActive(false);
            incorrectObjects_Manager.incorrectobjectsclicked++;
        }


        //WALL WRITING SCENE
        //CORRECT PENTAGRAM OBJECT 
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Pentagram_Object" && gameObject.tag == "Correct_Object")
        {
            Object_Dialogue_Script.clickedonpentagram();

            cluesheet_Manager.foundPentagramobject();
            pentagram_object.SetActive(false);
            writing_boxcollider.SetActive(false);
        }

        //INCORRECT WALL WRITING HIPPIE 
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Hippie_Writing" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrecthippiepowersymbol();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            hipppie_writng.SetActive(false);
        }
        //INCORRECT WALL WRITING POWER
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Power_Writing " && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonincorrecthippiepowersymbol();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            power_writing.SetActive(false);
        }

        //INCORRECT WALL WRITING COMMUNISM 
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Communism_Writing" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonanarchycommunismsymbol();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            communism_writing.SetActive(false);
        }

        //INCORRECT WALL WRITING ANARCHY
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Anarchy_Writing" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonanarchycommunismsymbol();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            anarchy_writing.SetActive(false);
        }

        //INCORRECT WALL WRITING ANKH
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Ankh_Writing " && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonankheyesymbol();

            incorrectObjects_Manager.incorrectobjectsclicked++;
             ankh_writing.SetActive(false);
        }

 

        //INCORRECT WALL WRITING EYE
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Eye_Writing" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonankheyesymbol();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            eye_writing.SetActive(false);
        }





        //COUCH SCENE 
        //CLICKED ON CORRECT TAROT CARD
        if (Input.GetMouseButtonDown(0) && gameObject.name == "TarotCard_Object" && gameObject.tag == "Correct_Object")
        {
            Object_Dialogue_Script.clickedontarotcard();

            couch_boxcolider.SetActive(false);
            tarot_object.SetActive(false);

            cluesheet_Manager.foundTarotCardObject();
        }

        //CLICKED ON INCORRECT TOWER/FOOL/MOON CARD
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Moon_Card" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedontowerfoolmooncard();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            moon_card.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Tower_Card" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedontowerfoolmooncard();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            tower_card.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Fool_Card" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedontowerfoolmooncard();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            fool_card.SetActive(false);
        }

        //CLICKED ON INCORRECT BIRTHDAY CARD AND 2 CARD 
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Birthday_Card" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonbirthdaycard();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            birthday_card.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "2_Card" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedontwocard();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            two_card.SetActive(false);
        }





        //CHEST SCENE
        //CORRECT GOATS BLOOD OBJECT
        if (Input.GetMouseButtonDown(0) && gameObject.name == "GoatBlood_Object" && gameObject.tag == "Correct_Object")
        {
            Object_Dialogue_Script.clickedongoatsblood();

           
            goatblood_object.SetActive(false);
            chest_boxcollider.SetActive(false);

            cluesheet_Manager.foundGoatsBlood();
        }

        //INCORRECT VIALS 1/2
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Woof_Vials" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonwoofmeowvials();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            woof_vial.SetActive(false);
        }

        if(Input.GetMouseButtonDown(0) && gameObject.name == "Moo_Vials" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonoinkmoovials();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            moo_vial.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Oink_Vials" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonoinkmoovials();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            oink_vial.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Meow_Vials" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedonwoofmeowvials();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            meow_vial.SetActive(false);
        }










        //BOARD SCENE
        //CORRECT DRAWING OBJECT
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Drawing_Object" && gameObject.tag == "Correct_Object")
        {

            Object_Dialogue_Script.clickedondrawing();

            drawing_object.SetActive(false);
            board_boxcollider.SetActive(false);

            cluesheet_Manager.foundDrawing();
        }

        //INCORRECT GIRL 1/3/5/7
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Girl_1" && gameObject.tag == "Incorrect_Object")
        {

            Object_Dialogue_Script.clickedongirl1357();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            girl1.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Girl_3" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedongirl1357();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            girl3.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Girl_5" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedongirl1357();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            girl5.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Girl_7" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedongirl1357();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            girl7.SetActive(false);
        }


        //CLICKED ON GIRL 2/4/6
        if (Input.GetMouseButtonDown(0) && gameObject.name == "Girl_2" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedongirl246();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            girl2.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Girl_4" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedongirl246();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            girl4.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Girl_6" && gameObject.tag == "Incorrect_Object")
        {
            Object_Dialogue_Script.clickedongirl246();

            incorrectObjects_Manager.incorrectobjectsclicked++;
            girl6.SetActive(false);
        }

    }




    public void OnMouseOver()
    {
      
        //LETTER ZOOMED IN
        if (Input.GetMouseButtonDown(1) && gameObject.name == "Letter_Envelope")
        {
            Object_Dialogue_Script.clickedonevnevlopeininventory();
            
        }
        //CASE FILE ZOOMED IN
        if (Input.GetMouseButtonDown(1) && gameObject.name == "Case_File")
        {

            Object_Dialogue_Script.clickedonCcasefile();
        }

        //BLANK PAPER ZOOMED IN
        if (Input.GetMouseButtonDown(1) && gameObject.name == "Blank_Paper")
        {
            Object_Dialogue_Script.clickedonblankpieceofpaper();

        }

        //CLUESHEET ZOOMED IN
        if (Input.GetMouseButtonDown(1) && gameObject.name == "Clue_Paper")
        {
            bool hasrun = false;
            if (!hasrun)
            {
                Object_Dialogue_Script.clickedoncluesheet();

                hasrun = true;
                if(hasrun==true)
                {
                    Object_Dialogue_Script.StopCoroutine(Object_Dialogue_Script.clickedOnClueSheet());
                }
            }
         
          
        }



       







       
    }
}
