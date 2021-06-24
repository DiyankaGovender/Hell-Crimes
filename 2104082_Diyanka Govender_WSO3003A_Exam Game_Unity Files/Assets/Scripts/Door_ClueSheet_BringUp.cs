using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_ClueSheet_BringUp : MonoBehaviour
{
    public GameObject cluescene;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cluescene.SetActive(true);

        }
    }
}
