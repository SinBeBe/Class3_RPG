using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStage : MonoBehaviour
{

    public GameObject teamUI;
    public int[] stageNum = new int[2];

    public void OnClick()
    {
        GameManager.Instance.stage[0] = stageNum[0];
        GameManager.Instance.stage[1] = stageNum[1];
        teamUI.SetActive(true);
    }
    public void OnStartStage()
    {
        SceneManager.LoadScene("Stage");
    }

    public void OnClickExit()
    {
        GameManager.Instance.stage[0] = 0;
        GameManager.Instance.stage[1] = 0;
        teamUI.SetActive(false);
    }
}
