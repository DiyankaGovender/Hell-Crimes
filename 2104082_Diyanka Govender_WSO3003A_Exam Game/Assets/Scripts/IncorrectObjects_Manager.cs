using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IncorrectObjects_Manager : MonoBehaviour
{
    public GameObject gameOverGO;
    
    public GameObject UIbar;

    public GameObject bad1;
    public GameObject bad2;
    public GameObject bad3;
    public GameObject bad4;
    public GameObject bad5;

    public int incorrectobjectsclicked;
    void Start()
    {
        UIbar.SetActive(false);

        bad1.SetActive(false);
        bad2.SetActive(false);
        bad3.SetActive(false);
        bad4.SetActive(false);
        bad5.SetActive(false);

        incorrectobjectsclicked = 0;

        gameOverGO.SetActive(false);
    }


    void Update()
    {
        if (incorrectobjectsclicked == 1)
        {
            bad1.SetActive(true);

        }

        if (incorrectobjectsclicked == 2)
        {
            bad2.SetActive(true);

        }

        if (incorrectobjectsclicked == 3)
        {
            bad3.SetActive(true);

        }

        if (incorrectobjectsclicked == 4)
        {
            bad4.SetActive(true);

        }

        if (incorrectobjectsclicked == 5)
        {
            bad5.SetActive(true);

        }

        if(incorrectobjectsclicked >= 5)
        {
            gameover();
        }
    }

    public void activatebar()
    {
        UIbar.SetActive(true);
    }

    public void gameover()
    {
        StartCoroutine(gameOver());
    }

    private IEnumerator gameOver()
    {
        yield return new WaitForSeconds(4f);
        gameOverGO.SetActive(true);
        
        
    }
}
