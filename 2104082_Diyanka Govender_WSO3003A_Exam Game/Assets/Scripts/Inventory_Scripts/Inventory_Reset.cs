using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Reset : MonoBehaviour
{
    public Inventory_BlankPaper inventory_BlankPaper;
    public Inventory_ClueSheet inventory_ClueSheet;

    public Inventory_LitCandle inventory_LitCandle;
    public Inventory_UnlitCandle inventory_UnlitCandle;

    public Inventory_Envelope inventory_Envelope;

    public Inventory_Casefile inventory_Casefile;

    public Inventory_Lighter inventory_Lighter;

    public GameObject inventory_scene;

    public GameObject finalcraftslot;
    public Sprite nonesprite;


    public GameObject casefile;
    public GameObject lighter;
    public GameObject unlitcandle;
    public GameObject litcandle;
    public GameObject letter;
    public GameObject blankpaper;
    public GameObject cluesheet;

    void Start()
    {
        
    }

   
    void Update()
    {
       
        if (inventory_scene.activeInHierarchy ==false)
        {

            casefile.transform.position = new Vector2(-3.75f, -1.49f);
            lighter.transform.position = new Vector2(-2.12f, -1.61f);
            unlitcandle.transform.position = new Vector2(-0.49f, -1.57f);
            litcandle.transform.position = new Vector2(-0.55f, -1.39f);
            letter.transform.position = new Vector2(1.3f, -1.71f);
            blankpaper.transform.position = new Vector2(3.12f, -1.63f);
            cluesheet.transform.position = new Vector2(3.12f, -1.7f);

            finalcraftslot.GetComponent<SpriteRenderer>().sprite = nonesprite;

        }
    }
}
