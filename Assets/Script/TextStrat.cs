using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStrat : MonoBehaviour
{
    public GameObject startText;
    public static bool isclick = false;
    void Start()
    {
        Invoke("OnSetActive", 1.5f);
    }
    public void OnSetActive()
    {
        startText.SetActive(true);
        isclick = true;
    }
}
