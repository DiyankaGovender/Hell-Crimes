using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Scene_FindFire : MonoBehaviour
{
    public bool FireOn;

    void Start()
    {
       FireOn = false;
    }


    void Update()
    {

    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("fire");
            FireOn = true;

        }
    }
}
