using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialouge_Script : MonoBehaviour
{
    public TextMeshProUGUI dialogue_textbox;

    public TextMeshProUGUI textbox_Icannowseebetter;
    public GameObject textbox_Icannowseebetter_GO;

    public TextMeshProUGUI Textbox_Now_Icanseeeverything;
    public GameObject Textbox_NowIcanseeeverythingG0;

    void Start()
    {
        StartCoroutine(noLightScene());
    }

 

    //DIALOUGE TEXT
    public IEnumerator noLightScene()
    {
        dialogue_textbox.text = "Fuck! It's pitch black in here.";
        yield return new WaitForSeconds(3f);
        dialogue_textbox.text = "I can't see a goddamn thing!";
        yield return new WaitForSeconds(3.5f);
        dialogue_textbox.text = "Wait...there's a candle on the floor...";
        yield return new WaitForSeconds(3.5f);
        dialogue_textbox.text = "Maybe it'll help me shed some light on this situation.";
        yield return new WaitForSeconds(3.5f);
        dialogue_textbox.text = "CANDLE ADDED TO INVENTORY";
        yield return new WaitForSeconds(5f);
        dialogue_textbox.text = "PRESS SPACE TO OPEN INVENTORY AND CRAFTING MENU";
        yield return new WaitForSeconds(4.5f);
        dialogue_textbox.text = "";
        yield break;
    }
  

    public IEnumerator unlitCandleandlighter()
    {
        dialogue_textbox.text = "Looks like I've got a bit more light around here...";
        yield return new WaitForSeconds(3.5f);
        dialogue_textbox.text = "LIT CANDLE ADDED TO INVENTORY";
        yield return new WaitForSeconds(5f);
        dialogue_textbox.text = "Maybe I should start a FIRE in that FIREPLACE over there...it'll help me see better.";
        yield return new WaitForSeconds(4f);
        dialogue_textbox.text = "LEFT CLICK AROUND SCENE TO INTERACT WITH OBJECTS";
        yield return new WaitForSeconds(4f);
        dialogue_textbox.text = "";
        yield break;
    }
    

    public void HadFire()
    {
        StartCoroutine(hasfire());
       
    }

    private IEnumerator hasfire()
    {
        textbox_Icannowseebetter.text = "I can now see better! I wonder if there's a LIGHT around here...";
        yield return new WaitForSeconds(5f);
        textbox_Icannowseebetter.text = "";
        textbox_Icannowseebetter_GO.SetActive(false);
        yield break;

    }

    public void HasLight()
    {
        StartCoroutine(hasLight());
    }
    private IEnumerator hasLight()
    {
        Textbox_Now_Icanseeeverything.text = "Now I can see everything...it looks like there's something on the PAINTING...I should investigate it...";
        yield return new WaitForSeconds(5f);
        Textbox_Now_Icanseeeverything.text = "";
        Textbox_NowIcanseeeverythingG0.SetActive(false);
        yield break;

    }


}
