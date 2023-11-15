using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Roll : MonoBehaviour
{

    /* 1�� : 6�� 70% 5
     * 2�� : 4�� 15% 3
     * 3�� : 3�� 7% 2
     * 4�� : 2�� 4% 1
     * 5�� : 1�� 3% 1
     * 6�� : 2�� 1% 
     */


    public GameObject noCrystal;
    public GameObject[] Star = new GameObject[6];

    public void OnRoll(int n)
    {

        if(n == 1)
        {
            if (GameManager.Instance.crystal >= 100)
            {
                UIManager.Instance.isRollclick = true;
                StartCoroutine(ShowCard(n));
                UIManager.Instance.isRollclick = false;
            }
            else if (GameManager.Instance.crystal < 100)
            {
                StartCoroutine(Wait());
            }
        }
        else if(n == 10)
        {
            if (GameManager.Instance.crystal >= 1000)
            {
                UIManager.Instance.isRollclick = true;
                StartCoroutine(ShowCard(n));
                UIManager.Instance.isRollclick = false;
            }
            else if (GameManager.Instance.crystal < 1000)
            {
                StartCoroutine(Wait());
            }
        }
        
    }

    int grade = 0;
    public int ShowNumber()
    {
        int gradeRandom = Random.Range(0, 100000) + 1;

        
        if (gradeRandom >= 1 && gradeRandom <= 70000) //1��
        {
            grade = 1;
            Star[grade - 1].SetActive(true);
        }
        else if (gradeRandom >= 70001 && gradeRandom <= 85000) //2��
        {
            grade = 2;
            Star[grade - 1].SetActive(true);
        }
        else if (gradeRandom >= 85001 && gradeRandom <= 92000) //3��
        {
            grade = 3;
            Star[grade - 1].SetActive(true);
        }
        else if (gradeRandom >= 92001 && gradeRandom <= 96000) //4��
        {
            grade = 4;
            Star[grade - 1].SetActive(true);
        }
        else if (gradeRandom >= 96001 && gradeRandom <= 99900) //5��
        {
            grade = 5;
            Star[grade - 1].SetActive(true);
        }
        else if (gradeRandom >= 99901) //6��
        {
            grade = 6;
            Star[grade - 1].SetActive(true);
        }

        Debug.Log(grade);
        return grade;
    }
    

    IEnumerator ShowCard(int n)
    {
        GetComponent<Button>().interactable = false;
        GameManager.Instance.crystal -= n * 100;
        UIManager.Instance.reset();
        for (int j = 0; j < n; j++)
        {
            var cardlist = UIManager.Instance.cardList[ShowNumber()];
            var selectedCard = cardlist[Random.Range(0, cardlist.Count)];
            selectedCard.gameObject.SetActive(true);
            GameManager.Instance.Collection[selectedCard.gameObject.name] = true;
            GameManager.Instance.upGradeCharacter[selectedCard.cardNum - 1] += 1;
            Star[grade - 1].SetActive(true);
            yield return new WaitForSeconds(1.5f);
            selectedCard.gameObject.SetActive(false);
            Star[grade - 1].SetActive(false);
            yield return new WaitForSeconds(0.3f);
        }
        GetComponent<Button>().interactable = true;
    }

    IEnumerator Wait()
    {
        GetComponent<Button>().interactable = false;
        noCrystal.SetActive(true);
        yield return new WaitForSeconds(1);
        noCrystal.SetActive(false);
        GetComponent<Button>().interactable = true;
    }

}
