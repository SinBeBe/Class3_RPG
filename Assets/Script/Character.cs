using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Character : MonoBehaviour
{

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Onclick(string n)
    {
        if (n == "Up")
        {
            GameManager.Instance.getGrade++;
            UIManager.Instance.resetGrade();
        }
        else if (n == "Back")
        {
            GameManager.Instance.getGrade--;
            UIManager.Instance.resetGrade();
        }
    }

}
