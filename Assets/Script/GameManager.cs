using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public int getGrade = 1;
    public int crystal = 0;
    public GameObject[] getCard = new GameObject[18];
    public int LastClearStage = 0;
    public Dictionary<string, bool> Collection = new();
    public int[] upGradeCharacter = new int[12];
    public Card selectedCardnum;
    public int[] stage = new int[2];




    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        Collection.Add("건희", false);
        Collection.Add("예찬", false);
        Collection.Add("시후", false);
        Collection.Add("건주", false);
        Collection.Add("지완", false);
        Collection.Add("미정", false);
        Collection.Add("승규", false);
        Collection.Add("승표", false);
        Collection.Add("은후", false);
        Collection.Add("송주", false);
        Collection.Add("우석", false);
        Collection.Add("경주", false);
        Collection.Add("동학", false);
        Collection.Add("서준", false);
        Collection.Add("정현", false);
    }


    private void Update()
    {
        if(getGrade == 0 || getGrade == 8)
        {
            getGrade = 1;
        }
    }
    public void isWin()
    {
        crystal += 500;
    }

}
