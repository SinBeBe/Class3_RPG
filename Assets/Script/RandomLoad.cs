using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomLoad : MonoBehaviour
{
    public void OnClickExit()
    {
        SceneManager.LoadSceneAsync("RandomScreen");
    }
}
