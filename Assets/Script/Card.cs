using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Card : MonoBehaviour
{
    public string cardName;
    public int grade;
    public int cardNum;

    private void Start()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "GameScreen")
        {
            gameObject.SetActive(true);
        }
        else if(currentSceneName == "RandomScreen")
        {
            gameObject.SetActive(false);
        }
    }
}
