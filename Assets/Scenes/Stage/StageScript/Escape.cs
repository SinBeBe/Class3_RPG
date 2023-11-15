using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    public GameObject team;

    public void OnClickEsc()
    {
        team.SetActive(false);
    }
}
