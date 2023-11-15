using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Adventrue : MonoBehaviour
{
    public void OnClickExit()
    {
        SceneManager.LoadScene("AdventrueScreen");
    }
}
