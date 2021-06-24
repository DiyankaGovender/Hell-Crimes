using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting_Checker : MonoBehaviour
{
   
    public Dialouge_Script dialouge_Script;
    public Object_Dialogue_Script object_Dialogue_Script;

    public GameObject crafting_slotFinal;

    public Inventory_Lighter inventory_Lighter;
    public Inventory_UnlitCandle inventory_UnlitCandle;
    public Inventory_Casefile inventory_Casefile;
    public Inventory_LitCandle inventory_LitCandle;
    public Inventory_BlankPaper inventory_BlankPaper;
    public Inventory_Envelope inventory_Envelope;

    public bool candlelit;

    public Sprite litCandle;
    public Sprite ClueSheet;
    


    //SPRITE OBJECTS 
    public GameObject unlitCandle;
    public GameObject casefile;
    public GameObject lighter;
    public GameObject litCandleGO;
    public GameObject letterenvelope;
    public GameObject blankpaper;
    public GameObject cluesheet;
    void Start()
    {
        letterenvelope.SetActive(false);
        candlelit = false;
        litCandleGO.SetActive(false);
        blankpaper.SetActive(false);
        cluesheet.SetActive(false);
    }


    void Update()
    {
        unlitcandleandlighter();
        lighterandcasefile();
        unlitcandleandcasefile();
        blankpaperandcandleorlighter();

    }

    //CORRECT LIGHTER + UNLIT CANDLE
    public void unlitcandleandlighter()
    {
        bool hasrun = false;
        if (!hasrun)
        {
            if (inventory_UnlitCandle.candleisOnCraftingSlot1 == true && inventory_Lighter.lighterisOnCraftingSlot2 == true ||
            inventory_UnlitCandle.candleisOnCraftingSlot2 == true && inventory_Lighter.lighterisOnCraftingSlot1 == true)
            {
                candlelit = true;
                crafting_slotFinal.GetComponent<SpriteRenderer>().sprite = litCandle;
                unlitCandle.SetActive(false);

                //RESET CASEFILE AND LIGHTER POSITION
                inventory_Casefile.resetpos();
                inventory_Casefile.caseFileisOnCraftingSlot1 = false;
                inventory_Casefile.caseFileisOnCraftingSlot2 = false;

                inventory_Lighter.ResetPos();
                inventory_Lighter.lighterisOnCraftingSlot1 = false;
                inventory_Lighter.lighterisOnCraftingSlot2 = false;

                inventory_UnlitCandle.resetpos();
                inventory_UnlitCandle.candleisOnCraftingSlot1 = false;
                inventory_UnlitCandle.candleisOnCraftingSlot2 = false;


                litCandleGO.SetActive(true);
                StartCoroutine(dialouge_Script.unlitCandleandlighter());
                hasrun = true;
            }
        }
        
    }


    //INCORRECT LIGHTER AND CASE FILE
    public void lighterandcasefile()
    {
        bool hasrun = false;
        if (!hasrun)
        {
            if (inventory_Casefile.caseFileisOnCraftingSlot1 == true && inventory_Lighter.lighterisOnCraftingSlot2 == true ||
           inventory_Casefile.caseFileisOnCraftingSlot2 == true && inventory_Lighter.lighterisOnCraftingSlot1 == true)
            {
               
               
                hasrun = true;

                //RESET 
                inventory_Casefile.resetpos();
                casefile.transform.position = new Vector2(-3.75f, -1.49f);
                inventory_Casefile.caseFileisOnCraftingSlot1 = false;
                inventory_Casefile.caseFileisOnCraftingSlot2 = false;

                inventory_Lighter.ResetPos();
                inventory_Lighter.lighterisOnCraftingSlot1 = false;
                inventory_Lighter.lighterisOnCraftingSlot2 = false;

                inventory_UnlitCandle.resetpos();
                inventory_UnlitCandle.candleisOnCraftingSlot1 = false;
                inventory_UnlitCandle.candleisOnCraftingSlot2 = false;
            }
        }
       
    }

    //INCORRECT UNLIT CANDLE AND CASE FILE
    public void unlitcandleandcasefile()
    {
        bool hasrun = false;
        if (!hasrun)
        {
            if (inventory_UnlitCandle.candleisOnCraftingSlot1 == true && inventory_Casefile.caseFileisOnCraftingSlot2 == true ||
            inventory_UnlitCandle.candleisOnCraftingSlot2 == true && inventory_Casefile.caseFileisOnCraftingSlot1 == true)
            {
               
                

                //RESET 
                inventory_Casefile.resetpos();
                inventory_Casefile.caseFileisOnCraftingSlot1 = false;
                inventory_Casefile.caseFileisOnCraftingSlot2 = false;

                inventory_Lighter.ResetPos();
                inventory_Lighter.lighterisOnCraftingSlot1 = false;
                inventory_Lighter.lighterisOnCraftingSlot2 = false;

                inventory_UnlitCandle.resetpos();
                inventory_UnlitCandle.candleisOnCraftingSlot1 = false;
                inventory_UnlitCandle.candleisOnCraftingSlot2 = false;

                hasrun = true;
            }
        }
       
    }


    //CORRECT LIGHTER OR LIT CANDLE AND BLANK PIECE OF PAPER
    public void blankpaperandcandleorlighter()
    {
        bool hasrun = false;
        if (!hasrun)
        {
            if (inventory_LitCandle.litcandleisOnCraftingSlot1 == true && inventory_BlankPaper.blankpaperisOnCraftingSlot2 == true ||
            inventory_LitCandle.litcandleisOnCraftingSlot2 == true && inventory_BlankPaper.blankpaperisOnCraftingSlot1 == true ||
            inventory_Lighter.lighterisOnCraftingSlot1 == true && inventory_BlankPaper.blankpaperisOnCraftingSlot2 == true ||
            inventory_Lighter.lighterisOnCraftingSlot2 == true && inventory_BlankPaper.blankpaperisOnCraftingSlot1 == true)
            {
                //SLOT 3 
                crafting_slotFinal.GetComponent<SpriteRenderer>().sprite = ClueSheet;
                //CLUESHEET WORKING
                cluesheet.SetActive(true);
                blankpaper.SetActive(false);

                //RESET POSTITION
                inventory_Casefile.resetpos();
                inventory_Lighter.ResetPos();
                inventory_LitCandle.ResetPos();
                inventory_Envelope.resetpos();


                //DISABLE CRAFTING
                casefile.GetComponent<Inventory_DragDrop>().enabled = false;
                lighter.GetComponent<Inventory_DragDrop>().enabled = false;
                inventory_LitCandle.GetComponent<Inventory_DragDrop>().enabled = false;
                inventory_Envelope.GetComponent<Inventory_DragDrop>().enabled = false;

                //CLUESHEET
                object_Dialogue_Script.craftedCluesheet();
                hasrun = true;
            }

        }

    }

    //LETTER ACTIVATED 
    public void letterenvelopeactive()
    {
        letterenvelope.SetActive(true);
    }

    //BLANK PAPER ACTIVATED
    public void blankpaperactive()
    {
        blankpaper.SetActive(true);
    }
}
