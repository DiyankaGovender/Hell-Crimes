using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cluesheet_Manager : MonoBehaviour
{
    public GameObject pentagramCheck;
    public GameObject tarotCheck;
    public GameObject goatbloodCheck;
    public GameObject drawingCheck;
    public GameObject numberCheck;
    public GameObject skullcheck;

    public bool pentagramfound;
    public bool tarotfound;
    public bool goatfound;
    public bool drawingfound;
    public bool numberfound;
    public bool skullfound;

    public GameObject door_boxcollider;

    public GameObject Textbox_Object_Text;

    public TextMeshProUGUI final_dialogue;
    public GameObject final_dialogue_GO;

    void Start()
    {
        pentagramCheck.SetActive(false);
        tarotCheck.SetActive(false);
        goatbloodCheck.SetActive(false);
        drawingCheck.SetActive(false);
        numberCheck.SetActive(false);
        skullcheck.SetActive(false);

        pentagramfound = false;
        tarotfound = false;
        goatfound = false;
        drawingfound = false;
        numberfound = false;
        skullfound = false;

        door_boxcollider.SetActive(false);
    }

    public void found666object()
    {
        numberCheck.SetActive(true);
        numberfound = true;

    }

    public void foundSkullobject()
    {
        skullcheck.SetActive(true);
        skullfound = true;
    }
 
    public void foundPentagramobject()
    {
        pentagramCheck.SetActive(true);
        pentagramfound = true;
    }

    public void foundTarotCardObject()
    {
        tarotCheck.SetActive(true);
        tarotfound = true;
    }

    public void foundGoatsBlood()
    {
        goatbloodCheck.SetActive(true);
        goatfound = true;
    }

    public void foundDrawing()
    {
        drawingCheck.SetActive(true);
        drawingfound = true;
    }

    void Update()
    {
        foundAllClues();
    }

    public void foundAllClues()
    {
        if(pentagramfound==true && tarotfound==true && goatfound==true && drawingfound==true && numberfound==true && skullfound == true)
        {
            Debug.Log("FOUND ALL OBJECTS");
            StartCoroutine(finalstagedialouge());
            door_boxcollider.SetActive(true);


        }
    }

    private IEnumerator finalstagedialouge()
    {
        yield return new WaitForSeconds (7f);
        Textbox_Object_Text.SetActive(false);
        door_boxcollider.SetActive(true);
        final_dialogue.text = "I found all the objects on the cluesheet. I should check out the door.";
        yield return new WaitForSeconds(4f);
        final_dialogue_GO.SetActive(false);
    }
}
