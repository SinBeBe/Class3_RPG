using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public GameObject OptionScreen;
    bool isScreen = false;

    public void OnClickOption()
    {
        if(isScreen == false)
        {
            OnSetActive();
        }
        else if(isScreen == true)
        {
            OndownActive();
        }
    }

    void OnSetActive()
    {
        isScreen = true;
        OptionScreen.SetActive(true);
    }

    void OndownActive()
    {
        isScreen = false;
        OptionScreen.SetActive(false);
    }
}
