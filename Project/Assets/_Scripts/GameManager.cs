using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lifes = 3;
    public int currentLifes;
    public TMP_Text textLifes;

    private void Start()
    {
        currentLifes = lifes;
    }



    void Update()
    {
        lifes = currentLifes;

        textLifes.text = "Lifes: " + lifes.ToString();

        if (lifes <= 0)
        {
            lifes = 3;
            SceneManager.LoadScene(0);
        }
    }
}
