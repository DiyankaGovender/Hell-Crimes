using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Win_Condition : MonoBehaviour
{
    public Tarot_Card tarot_Card;
    public Goat goat;
    public Pentagram pentagram;
    public Drawing drawing;
    public Number number;
    public Skull skull;

    public TextMeshProUGUI win_text;

    public GameObject win_scene;
    public GameObject door_scene;

    void Start()
    {
        win_scene.SetActive(false);
    }

   
    void Update()
    {
        if(tarot_Card.tarotCardisOnBlueCircle==true &&
            goat.goatisOnGreenCircle ==true &&
            pentagram.pentagramisOnRedCircle==true &&
            drawing.drawingisOnPurpleCircle ==true &&
            number.numberisOnOrangeCircle ==true &&
             skull.skullCardisOnYelllowCircle == true)
        {
            bool hasrun = false;
                if (hasrun==false)
            {
                winstate();
                hasrun = true;
            }
          
        }
    }

    public void winstate()
    {
        StartCoroutine(winState());
    }

    private IEnumerator winState()
    {
        yield return new WaitForSeconds(1.5f);
        win_scene.SetActive(true);
        door_scene.SetActive(false);

        
        win_text.text = "Don't worry kid, you're safe now.It looks like I cracked this case wide open! Hell can rest easy another night.THE END.";
        
    }
}
