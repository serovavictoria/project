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
        TimeManager.instance.EndTime();

        assessmentText.text = "���� ������: " + Math.Round(PlayerPrefs.GetFloat("assessment")).ToString();

        timeText.text = "����� ����������� ����: " + TimeManager.instance.GetTotalTimePlayed();

        Debug.Log(DateTime.Now);
    }
}
