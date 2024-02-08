using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private DateTime startTime;
    private DateTime endTime;

    public static TimeManager instance;

    private void Awake()
    {
        // Ensure only one instance of GameManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartTime()
    {
        startTime = DateTime.Now;
    }

    public void EndTime()
    {
        endTime = DateTime.Now;
    }

    public String GetTotalTimePlayed()
    {
        TimeSpan time = endTime - startTime;

        return time.ToString(@"mm\:ss");
    }

}
