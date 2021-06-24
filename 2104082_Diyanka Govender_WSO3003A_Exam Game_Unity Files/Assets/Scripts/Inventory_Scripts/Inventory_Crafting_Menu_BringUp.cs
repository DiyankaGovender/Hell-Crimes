using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Crafting_Menu_BringUp : MonoBehaviour
{
    public GameObject inventory_crafting_scene;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory_crafting_scene.SetActive(true);
            
        }
    }
}
