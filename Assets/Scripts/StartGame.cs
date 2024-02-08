using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private StartGameTimeSciptableObject StartGameTime;

    public void StartNewGame()
    {
        string directoryPath = @"C:\DiplomImages\";

        // Create the directory if it doesn't exist
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        StartGameTime.ticks = DateTime.Now.Ticks;
        PlayerPrefs.SetFloat("assessment", 0);
    }
}
