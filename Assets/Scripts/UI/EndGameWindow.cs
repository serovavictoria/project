using System;
using TMPro;
using UnityEngine;

public class EndGameWindow : AbstractWindowUI
{
    [SerializeField]
    private TMP_Text assessmentText;

    [SerializeField]
    private TMP_Text timeText;

    [SerializeField]
    private StartGameTimeSciptableObject startGameTimeSciptableObject;

    public override void OpenWindow()
    {
        base.OpenWindow();

        assessmentText.text = "Ваша оценка: " + Math.Round(PlayerPrefs.GetFloat("assessment")).ToString();

        TimeSpan time = DateTime.Now - new DateTime(startGameTimeSciptableObject.ticks);

        timeText.text = "Время прохождения игры: " + Convert.ToString(time.Minutes) + ":" + Convert.ToString(time.Seconds);

        Debug.Log(DateTime.Now);
    }
}
