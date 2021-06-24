using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Object_Dialogue_Script : MonoBehaviour
{
    public TextMeshProUGUI object_textbox;
   
    public TextMeshProUGUI cluesheet;
    public GameObject cluesheetGO;

    public TextMeshProUGUI cluesheetinvetory;
    public GameObject cluesheetinventoryGO;

    public TextMeshProUGUI casefile;
    public GameObject casefileGO;

    public TextMeshProUGUI letter;
    public GameObject letterGO;

    public TextMeshProUGUI blankpaper;
    public GameObject blankpaperGO;

    public TextMeshProUGUI clock;
    public GameObject clokcGO;

    public TextMeshProUGUI skull;
    public GameObject skullGO;

    public TextMeshProUGUI couch;
    public GameObject couchGO;

    public TextMeshProUGUI board;
    public GameObject boardGO;

    public TextMeshProUGUI wall;
    public GameObject wallGO;

    public TextMeshProUGUI chest;
    public GameObject chestGO;

    public Crafting_Checker crafting_Checker;
    public IncorrectObjects_Manager incorrectObjects_Manager;

    public BoxCollider2D clock_boxcollider;
    public BoxCollider2D skeleton_boxcollider;
    public BoxCollider2D painting_boxcollider;
    public BoxCollider2D bookshelf_boxcollider;
    public BoxCollider2D wall_boxcollider;
    public BoxCollider2D couch_boxcollider;
    public BoxCollider2D board_boxcollider;
    public BoxCollider2D chest_boxcollider;

    public void start()
    {
        clock_boxcollider.enabled = false;
        skeleton_boxcollider.enabled = false;
        painting_boxcollider.enabled = false;
        bookshelf_boxcollider.enabled = false;
        wall_boxcollider.enabled =false;
        couch_boxcollider.enabled = false;
        board_boxcollider.enabled = false;
        chest_boxcollider.enabled = false;

       
    }

    public void Update()
    {
       
    }

    //CLICKED ON PAINTING
    public void clickedonpainting()
    {
        StartCoroutine(clickedOnPainting());
    }


    private IEnumerator clickedOnPainting()
    {
        
        {
            
            object_textbox.text = "Here's a painting of Florence LaVeau, the head of the coven.";
            yield return new WaitForSeconds(3.5f);
            object_textbox.text = "There's a letter on it, I should open it and see what's inside.";
            crafting_Checker.letterenvelopeactive();
            yield return new WaitForSeconds(3.5f);
            object_textbox.text = "";
            

         

            yield break;
        }
       

    }

    //CLICKED ON ENVELOPE ON PAINTING
    public void clickedonenvelopeonpainting()
    {
        StartCoroutine(clickedOnEnvelopeOnPainting());
    }

    private IEnumerator clickedOnEnvelopeOnPainting()
    {
        object_textbox.text = "LETTER ADDED TO INVENTORY";
        yield return new WaitForSeconds(3.5f);
        crafting_Checker.letterenvelopeactive();
        object_textbox.text = "";
        yield break;

    }


    //CLICKED ON ENVELOPE IN INVENTORY
    public void clickedonevnevlopeininventory()
    {
        StartCoroutine(clickedOnEnvelopeInInventory());
    }

    private IEnumerator clickedOnEnvelopeInInventory()
    {
        yield return new WaitForSeconds(23f);
        letter.text = "Hmmm...so it looks like the vampire kid might be trapped behind that door over there.";
        yield return new WaitForSeconds(5f);
        letter.text = "Don't get ahead of yourself Dick, first you gotta find the book Florence mentioned in the letter.";
        yield return new WaitForSeconds(5.5f);
        letter.text = "Maybe I should check the TOP ROW of the bookshelf, that would be a good start.";
        yield return new WaitForSeconds(8f);
        letterGO.SetActive(false);
        yield break;
    }


    //CLICKED ON BOOKSHELF
    public void clickedonbookshelf()
    {
        StartCoroutine(clickedOnBookshelf());
    }

    private IEnumerator clickedOnBookshelf()
    {
        object_textbox.text = "There's some intresting reads here...";
        yield return new WaitForSeconds(3.5f);
        object_textbox.text = "According to the letter, I should find a book about a Shakespearean tragedy.";
        yield return new WaitForSeconds(3.5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT BOOK ROMEO AND JULIETTE 
    public void clickedonromeonandjuliette()
    {
        StartCoroutine(clickedOnRomeoJuliette());
    }

    private IEnumerator clickedOnRomeoJuliette()
    {
        object_textbox.text = "This is a Shakespearean tragedy, but I don't think there's a mad king in this play.";
        yield return new WaitForSeconds(3.5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT BOOK HAMLET
    public void clickedonhamlet()
    {
        StartCoroutine(clickedOnHamlet());
    }
    private IEnumerator clickedOnHamlet()
    {
        object_textbox.text = "This is a Shakespearean tragedy, but it's about a mad prince, not a mad king.";
        yield return new WaitForSeconds(3.5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT BOOK HARRY POTTER 
    public void clickedonharrypotter()
    {
        StartCoroutine(clickedOnHarryPotter());
    }

    private IEnumerator clickedOnHarryPotter()
    {
        object_textbox.text = "Of course the witches like Harry Potter, it features witchcraft after all...";
        yield return new WaitForSeconds(3.5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT BOOK EAT WITCH LOVE
    public void clickedoneatwitchlove()
    {
        StartCoroutine(clickedOnEatWitchLove());
    }

    private IEnumerator clickedOnEatWitchLove()
    {
        object_textbox.text = "I'm not one for self help books.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON CORRECT BOOK MACBETH
    public void clickedoncorrectbook()
    {
        StartCoroutine(clickedOnCorrectBook());
    }
    private IEnumerator clickedOnCorrectBook()
    {
        object_textbox.text = "Ah, this is the book! Macbeth is the Shakesprean tragedy about a mad king.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "There's a piece of paper inside.";
        yield return new WaitForSeconds(3.5f);
        object_textbox.text = "BLANK PIECE OF PAPER ADDED TO INVENTORY";
        yield return new WaitForSeconds(2f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON CASEFILE IN INVENTORY
    public void clickedonCcasefile()
    {
        StartCoroutine(clickedOnCaseFile());
    }
    private IEnumerator clickedOnCaseFile()
    {
       casefile.text = "I gotta solve this case before all hell breaks loose! Pun intended.";
        yield return new WaitForSeconds(4f);
        object_textbox.text = "";
        casefileGO.SetActive(false);
        yield break;
    }

    //CLICKED ON BLANK PIECE OF PAPER 
    public void clickedonblankpieceofpaper()
    {
        StartCoroutine(clickedOnBlankPieceOfPaper());
    }
    private IEnumerator clickedOnBlankPieceOfPaper()
    {
        
        blankpaper.text = "Hmmm...there's nothing on this paper...";
        yield return new WaitForSeconds(3.5f);
        blankpaper.text = "Wait. I can see traces of invisible ink.";
        yield return new WaitForSeconds(3.5f);
        blankpaper.text = "Some light will help me see what's on the paper.";
        yield return new WaitForSeconds(3.5f);
        blankpaperGO.SetActive(false);
        yield break;
    }



    //CLICKED ON CLUESHEET
    public void clickedoncluesheet()
    {
        StartCoroutine(clickedOnClueSheet());
    }
    public IEnumerator clickedOnClueSheet()
    {
        cluesheet.text = "Maybe these drawings on the paper are related to objects in this room.";
        yield return new WaitForSeconds(3.5f);
        cluesheet.text = "I should find the objects on the sheet. But I should be careful... I reckon based on the letter from LaVeau, if I touch too much of her stuff...I'm a gonner!";
        yield return new WaitForSeconds(7f);
        cluesheet.text = "I'd bet if I touch more than 5 ITEMS that aren't related to the door, its GAME OVER for me!";
        incorrectObjects_Manager.activatebar();
        yield return new WaitForSeconds(5f);
        cluesheet.text = "I should keep referring to the clue sheet as I look around. Maybe it'll change when I find the right objects.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        cluesheetGO.SetActive(false);
        
       

        
    }






   //CRAFTED CLUESHEET
   public void craftedCluesheet()
    {
        StartCoroutine(craftedcluesshet());
    }

    private IEnumerator craftedcluesshet()
    {
        cluesheetinvetory.text = "I can see there's stuff written on the paper now.";
        yield return new WaitForSeconds(3.5f);
        cluesheetinvetory.text = "RIGHT CLICK ON OBJECT TO VIEW.";
        yield return new WaitForSeconds(3f);
        cluesheetinventoryGO.SetActive(false);
    }


    //CLOCK SCENE
    //CLICKED ON CLOCK SCENE
    public void clickedonclockscene()
    {
        StartCoroutine(clickedOnClockScene());
    }

    private IEnumerator clickedOnClockScene()
    {
        clock.text = "Hey...I used to own a grandfather clock like this when I was alive...though the numbers were alot less weird.";
        yield return new WaitForSeconds(5f);
        clock.text = "";
        clokcGO.SetActive(false);
        yield break;
    }


    //CLICKED ON 666 OBJECT 
    public void clickedon666object()
    {
        StartCoroutine(clickedOn666Object());
    }

    private IEnumerator clickedOn666Object()
    {
        object_textbox.text = "Nice! Looks like I picked the right number. Looks like you've still got it Dick!";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT CLOCK OBJECTS
    public void clickedonincorrectclockobjects()
    {
        StartCoroutine(clickedOnIncorrectClockObjects());
    }

    private IEnumerator clickedOnIncorrectClockObjects()
    {
        object_textbox.text = "I think I'm choosing the wrong number on this clock, I should look at the clue sheet again to be safe.";
        yield return new WaitForSeconds(4f);
        object_textbox.text = "";
        yield break;
    }

    public void clickedonincorrectclockobjects2()
    {
        StartCoroutine(clickedOnIncorrectClockObjects2());
    }

    private IEnumerator clickedOnIncorrectClockObjects2()
    {
        object_textbox.text = "I should be careful.That wasn't the right number. Lemme look at the clue sheet again.";
        yield return new WaitForSeconds(4f);
        object_textbox.text = "";
        yield break;
    }




    //SKELETON SCENE 

    //CLICKED ON SKELETON SCENE
    public void clickedonskeletonscene()
    {
        StartCoroutine(clickedOnSkeletonScene());
    }
    private IEnumerator clickedOnSkeletonScene()
    {
       
        skull.text = "Sugar Skulls. As if I need another reminder that I'm dead.";
        yield return new WaitForSeconds(5f);
        skull.text = "";
        skullGO.SetActive(false);
       
        yield break;
    }

    //CLICKED ON SKULL OBJECT
    public void clickedonskullobject()
    {
        StartCoroutine(clickedOnSkullObject());
    }

    private IEnumerator clickedOnSkullObject()
    {
        object_textbox.text = "I picked the right skull! Guess I'm not a bonehead after all!";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT SKULL 1
    public void clickedonincorrectskull1()
    {
        StartCoroutine(clickedOnIncorrectSkull1());
    }

    private IEnumerator clickedOnIncorrectSkull1()
    {
        object_textbox.text = "These skulls all look the same, but there's got to be a difference. I gotta look at them closer.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT SKULL 2
    public void clickedonincorrectskull2()
    {
        StartCoroutine(clickedOnIncorrectSkull2());
    }
    private IEnumerator clickedOnIncorrectSkull2()
    {
        object_textbox.text = "Is there a difference between the skulls? I should double check the cluesheet.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }




    //WRITING SCENE
    //CLICKED ON WRITING SCENE
    public void clickedonwritingscene()
    {
        StartCoroutine(clickedOnWritingScene());
    }
    private IEnumerator clickedOnWritingScene()
    {
        wall.text = "That's a lot of symbols. But which one is the one I need?";
        yield return new WaitForSeconds(4f);
        wallGO.SetActive(false);
        yield break;
    }
    //CLICKED ON PENTAGRAM OBJECT 
    public void clickedonpentagram()
    {
        StartCoroutine(clickedonPentagram());
    }

    private IEnumerator clickedonPentagram()
    {
        object_textbox.text = "That's the right one! Of course the pentagram is the symbol of the witches' coven!";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT HIPPIE OR POWER SYMBOL
    public void clickedonincorrecthippiepowersymbol()
    {
        StartCoroutine(clickedonIncorrectHippiePowerSymbol());
    }
    private IEnumerator clickedonIncorrectHippiePowerSymbol()
    {
        object_textbox.text = "Cool symbol. But I don't think its the one I'm looking for...I should check the clue sheet to be safe.";
        yield return new WaitForSeconds(4f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT ANARCHY OR COMMUNISM SYMBOL
    public void clickedonanarchycommunismsymbol()
    {
        StartCoroutine(clickedonAnarchyCommunismSymbol());
    }
    private IEnumerator clickedonAnarchyCommunismSymbol()
    {
        object_textbox.text = "I used to follow the movement back in my younger years...but I don't think its the right symbol.";
        yield return new WaitForSeconds(4f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT ANKH OR EYE
    public void clickedonankheyesymbol()
    {
        StartCoroutine(clickedonAnkhEyeSymbol());
    }
    private IEnumerator clickedonAnkhEyeSymbol()
    {
        object_textbox.text = "A symbol from Egypt. The place was always on my bucket list... but I feel like this is the wrong symbol.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }







    //COUCH SCENE 

    //CLICKED ON COUCH SCENE
    public void clickedoncouchscene()
    {
        StartCoroutine(clickedOnCouchScene());
    }

    private IEnumerator clickedOnCouchScene()
    {
        couch.text = "This reminds me of the time I had a case where the killer had a calling card.";
        yield return new WaitForSeconds(5f);
        couchGO.SetActive(false);
        yield break;
    }
    //CLICKED ON CORRECT TAROT CARD OBJECT
    public void clickedontarotcard()
    {
        StartCoroutine(clickedOnTarotCard());
    }


    private IEnumerator clickedOnTarotCard()
    {
        object_textbox.text = "Ah, the hanged man drawing is related to the hanged man card. Damn, Dick you're in your element today!";
        yield return new WaitForSeconds(6f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT CARD TOWER/FOOL/TAROT 
    public void clickedontowerfoolmooncard()
    {
        StartCoroutine(clickedOnTowerFoolMoonCard());
    }

    private IEnumerator clickedOnTowerFoolMoonCard()
    {
        object_textbox.text = "It's a tarot card, but it's the wrong one. I've got to be careful and pick the right card.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT BIRTHDAY CARD 
    public void clickedonbirthdaycard()
    {
        StartCoroutine(clickedOnBirthdayCard());
    }

    private IEnumerator clickedOnBirthdayCard()
    {
        object_textbox.text = "Ugh. This reminds me about the time I was shot dead on my birthday. This is definitely the wrong card.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    public void clickedontwocard()
    {
        StartCoroutine(clickedOnTwoCard());
    }

    private IEnumerator clickedOnTwoCard()
    {
        object_textbox.text = "I love playing cards...but this is one wrong card too many. I need to check the clue sheet.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }









    //CHEST SCENE
    //CLICKED ON CHEST SCENE
    public void clickedonchestscene()
    {
        StartCoroutine(clickedOnChestScene());
    }

    private IEnumerator clickedOnChestScene()
    {
        chest.text = "A chest full of blood...honestly, not creepy at all by hell standards.";
        yield return new WaitForSeconds(5f);
        chestGO.SetActive(false);
        yield break;
    }

    //CLICKED ON CORRECT GOAT BLOOD OBJECT
    public void clickedongoatsblood()
    {
        StartCoroutine(clickedOnGoatsBlood());
    }

    private IEnumerator clickedOnGoatsBlood()
    {
        object_textbox.text = "I knew it! Of course goat blood is one of the objects, the witches use it in all their rituals.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT VIALS MOO OINK
    public void clickedonoinkmoovials()
    {
        StartCoroutine(clickedonOinkMooVials());
    }

    private IEnumerator clickedonOinkMooVials()
    {
        object_textbox.text = "Ugh...farm animal blood, gross...but,I don't think witches use this type of blood in their rituals.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //CLICKED ON INCORRECT MEOW WOOF
    public void clickedonwoofmeowvials()
    {
        StartCoroutine(clickedOnWoofMeowVials());
    }

    private IEnumerator clickedOnWoofMeowVials()
    {
        object_textbox.text = "Well this makes me miss my long dead pet...but I doubt the witches are scummy enough to use pet blood in their rituals.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }











    //BOARD SCENE
    //CLICKED ON BOARD SCENE 
    public void clickedonboardscene()
    {
        StartCoroutine(clickedOnBoardScene());
    }

    private IEnumerator clickedOnBoardScene()
    {
        board.text = "A corkboard with alot of drawings of vampire girls...but which one is Alice? Maybe I should look at my CASE FILE.";
        yield return new WaitForSeconds(8f);
        boardGO.SetActive(false);
        yield break;
    }


    //CLICKED ON CORRECT DRAWING OBJECT 
    public void clickedondrawing()
    {
        StartCoroutine(clickedOnDrawing());
    }

    private IEnumerator clickedOnDrawing()
    {
        object_textbox.text = "So this is what Alice apparently looks like...these witches are bad at drawing (and so is the creator of this game)";
        yield return new WaitForSeconds(8f);
        object_textbox.text = "";
        yield break;
    }



    //INCORRECT CLICKED ON GIRL 1/3/5/7
    public void clickedongirl1357()
    {
        StartCoroutine(clickedOnGirl1357());
    }

    private IEnumerator clickedOnGirl1357()
    {
        object_textbox.text = "Hmm...that isn't the right drawing...the clue is too vague...should I check another item in my inventory?";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }

    //INCORRECT CLICKED ON GIRL 2/4/6
    public void clickedongirl246()
    {
        StartCoroutine(clickedOnGirl246());
    }

    private IEnumerator clickedOnGirl246()
    {
        object_textbox.text = "There's no hint as to what the girl looks like on the clue sheet..let me check another item in my inventory.";
        yield return new WaitForSeconds(5f);
        object_textbox.text = "";
        yield break;
    }
}







