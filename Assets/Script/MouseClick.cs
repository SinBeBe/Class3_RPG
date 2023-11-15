using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && TextStrat.isclick == true)
        {
            SceneManager.LoadScene("GameScreen");

        }
    }

}
