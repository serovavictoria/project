using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private StartGameTimeSciptableObject StartGameTime;

    public void StartNewGame()
    {
        Debug.Log(DateTime.Now);
        StartGameTime.ticks = DateTime.Now.Ticks;
        PlayerPrefs.SetFloat("assessment", 0);
    }
}
