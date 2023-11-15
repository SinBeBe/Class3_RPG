using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCharacterUI : MonoBehaviour
{
    public GameObject CharacterPanel;

    public void Onclick()
    {
        CharacterPanel.SetActive(true);
        UIManager.Instance.resetGrade();
        UIManager.Instance.isCharacterclick = true;


        foreach (var col in UIManager.Instance.collectionCards)
        {
            if (GameManager.Instance.Collection[col.gameObject.name] == true)
            {
                col.GetComponent<Image>().color = Color.white;
            }
        }
    }

    public void OnEscapeClick()
    {
        UIManager.Instance.isCharacterclick = false;
        CharacterPanel.SetActive(false);
        UIManager.Instance.Up.SetActive(false);
        UIManager.Instance.Down.SetActive(false);
        GameManager.Instance.getGrade = 1;
    }
}
