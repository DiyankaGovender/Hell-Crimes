using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Swapper_Manager : MonoBehaviour
{
    public Dialouge_Script dialouge_Script;
    public Crafting_Checker crafting_Checker;
    public Main_Scene_FindLight main_Scene_FindLight;
    public Main_Scene_FindFire Main_Scene_FindFire;

    public GameObject main_scene_black;
    public GameObject main_scene_candlelit;
    public GameObject main_scene_firelit;
    public GameObject main_scene_fullylit;
    public GameObject main_scene_objets;

    void Start()
    {
        main_scene_black.SetActive(true);

        main_scene_candlelit.SetActive(false);
        main_scene_firelit.SetActive(false);
        main_scene_fullylit.SetActive(false);
        main_scene_objets.SetActive(false);
    }

 
    void Update()
    {
        //BLACK TO CANDLE LIT 
        if (crafting_Checker.candlelit == true)
        {
            main_scene_black.SetActive(false);
            main_scene_candlelit.SetActive(true);
            main_scene_firelit.SetActive(false);
            main_scene_fullylit.SetActive(false);
            main_scene_objets.SetActive(false);
        }
        //CANDLE LIT TO FIRE LIT
        if (Main_Scene_FindFire.FireOn == true)
        {
            hasfire();
        }


        //FIRE LIT TO FULLY LIT

        if (main_Scene_FindLight.lightsOn== true)
        {
            haslight();
        }
    }


    public void hasfire()
    {
        bool hasrun = false;
            if (!hasrun)
        {
            dialouge_Script.HadFire();

            main_scene_black.SetActive(false);
            main_scene_candlelit.SetActive(false);
            main_scene_firelit.SetActive(true);
            main_scene_fullylit.SetActive(false);
            main_scene_objets.SetActive(false);

            hasrun = true;
            if (hasrun == true)
            {
                StopAllCoroutines();
            }
        }
      
    }


    public void haslight()
    {
        bool hasrun = false;
        if (!hasrun)
        {
            dialouge_Script.HasLight();

            main_scene_black.SetActive(false);
            main_scene_candlelit.SetActive(false);
            main_scene_firelit.SetActive(false);
            main_scene_fullylit.SetActive(true);
            main_scene_objets.SetActive(true);

            hasrun = true;
            if (hasrun == true)
            {
                StopAllCoroutines();
            }
        }
    }

    
  
  
}
