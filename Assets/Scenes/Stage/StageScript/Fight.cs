using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Fight : MonoBehaviour
{
    public GameObject win;
    public GameObject lose;
    public Text startText;
    public GameObject gameStart;


    private void Start()
    {
        StartCoroutine(start());
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            Win();
        }
        if (Input.GetKeyDown(KeyCode.L) == true)
        {
            Lose();
        }
    }

    void Win()
    {
        win.gameObject.SetActive(true);
        GameManager.Instance.isWin();
        StartCoroutine(Wait(win));
    }
    void Lose()
    {
        lose.gameObject.SetActive(true);
        StartCoroutine(Wait(lose));
    }


    IEnumerator start()
    {
        gameStart.SetActive(true);
        startText.text = GameManager.Instance.stage[0] + "-" + GameManager.Instance.stage[1];
        yield return new WaitForSeconds(2f);
        gameStart.SetActive(false);
    }

    IEnumerator Wait(GameObject or)
    {
        yield return new WaitForSeconds(2f);
        or.gameObject.SetActive(false);
        SceneManager.LoadScene("GameScreen");
    }
}
