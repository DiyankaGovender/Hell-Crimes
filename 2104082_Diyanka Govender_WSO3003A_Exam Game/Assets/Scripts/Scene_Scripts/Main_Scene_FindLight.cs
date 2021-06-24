using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Scene_FindLight : MonoBehaviour
{
    public bool lightsOn;
 
    void Start()
    {
        lightsOn = false;
    }


    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && this.gameObject.name== "Light_Collider")
        {
            
            lightsOn = true;

        }
    }
}
