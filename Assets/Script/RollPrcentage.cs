using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollPrcentage : MonoBehaviour
{
    public GameObject Precent;
    bool isClick = false;

    public void OnRollPrcentage()
    {
        if(isClick == false)
        {
            isClick = true;
            Precent.SetActive(true);
        }

        else if(isClick == true)
        {
            isClick = false;
            Precent.SetActive(false);
        }
    }
}
