using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Final_Door : MonoBehaviour
{
    public BoxCollider2D door_boxcollider;
    public GameObject main_scene_fullylit;
    public GameObject mainscene_finaldoor;
    public TextMeshProUGUI door_textbox;
    public GameObject InventoryCrafting_Bringup_Manager;
    public GameObject doorCluesheetmanager;
    public GameObject incorrectUI;
    public GameObject doordialougueGO;
  
    void Start()
    {
        //DISABLE CLUESHEET MENU
       
        //whitesheetGO.SetActive(false);
        doorCluesheetmanager.GetComponent<Door_ClueSheet_BringUp>().enabled = false;
       
    }

    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0) && gameObject.name == "Door_BoxCollider")
        {
            Debug.Log("DOOR");
            door_boxcollider.enabled = false;

            //DISABLE INVENTORY MENU 
            InventoryCrafting_Bringup_Manager.GetComponent<Inventory_Crafting_Menu_BringUp>().enabled = false;

            //ENABLE CLUESHEET MENU
            doorCluesheetmanager.GetComponent<Door_ClueSheet_BringUp>().enabled = true;

            main_scene_fullylit.SetActive(false);
            mainscene_finaldoor.SetActive(true);
            incorrectUI.SetActive(false);
            doorCluesheetmanager.SetActive(true);
            StartCoroutine(doordialogue());


        }
    }

    public void Update()
    {
        
    }

    public void doorDialougue()
    {
        
    }

    private IEnumerator doordialogue()
    {
        door_textbox.text = "Maybe the colours on the door is related to the colours on the note. (PRESS SPACE TO OPEN CLUESHEET).";
        yield return new WaitForSeconds(3.5f);
        //door_textbox.text = "I should place the objects in their correct place in the door.";
        //yield return new WaitForSeconds(3.5f);
        //door_textbox.text = "PRESS SPACE TO OPEN CLUESHEET";
        //yield return new WaitForSeconds(4.5f);
        door_textbox.text = "";
        doordialougueGO.SetActive(false);
        if (doordialougueGO.activeInHierarchy == false)
        {
           
        }
       
    }

}
