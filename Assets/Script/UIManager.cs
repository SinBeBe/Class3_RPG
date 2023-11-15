using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public GameObject Up, Down;
    public Text grade;
    public Text Crystal;
    public bool isEnd = false;
    public GameObject[] gradeCharacter = new GameObject[7];

    public Card[] collectionCards;

    public static UIManager Instance
    {
        get
        {
            return _instance;
        }
    }

    public Dictionary<int, List<Card>> cardList = new();

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = GameObject.FindObjectOfType<UIManager>();
        }
        var cards = GameObject.FindObjectsOfType<Card>();

        for (int i = 0; i < 6; i++)
        {
            cardList.Add(i + 1, new List<Card>());
        }
        foreach (Card c in cards)
        {
            cardList[c.grade].Add(c);
        }

    }

    public void Start()
    {
        reset();

    }

    public bool isCharacterclick = false;
    public bool isRollclick = false;

    private void Update()
    {
        if(isCharacterclick == true)
        {
            if (GameManager.Instance.getGrade == 1)
            {
                Down.SetActive(false);
                Up.SetActive(true);
                for (int i = 0; i < 7; i++)
                {
                    gradeCharacter[i].SetActive(false);
                }
                gradeCharacter[GameManager.Instance.getGrade - 1].SetActive(true);
            }
            else if(GameManager.Instance.getGrade >= 2 && GameManager.Instance.getGrade <= 6)
            {
                Down.SetActive(true);
                Up.SetActive(true);
                for (int i = 0; i < 7; i++)
                {
                    gradeCharacter[i].SetActive(false);
                }
                gradeCharacter[GameManager.Instance.getGrade - 1].SetActive(true);
            }
            else if(GameManager.Instance.getGrade == 7)
            {
                Down.SetActive(true);
                Up.SetActive(false);
                for (int i = 0; i < 7; i++)
                {
                    gradeCharacter[i].SetActive(false);
                }
                gradeCharacter[GameManager.Instance.getGrade - 1].SetActive(true);
            }
        }
    }

    public void reset()
    {
        if(Crystal != null)
            Crystal.text = ": " + GameManager.Instance.crystal;
    }

    public void resetGrade()
    {
        grade.text = GameManager.Instance.getGrade + "¼º";
    }
}
