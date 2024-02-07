using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AssessmentController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text assessmentText;

    private void Start()
    {
        assessmentText.text = "���� ������: " + PlayerPrefs.GetFloat("assessment", 2.5f);
    }

    public void UpdateAssessment()
    {
        assessmentText.text = "���� ������: " + PlayerPrefs.GetFloat("assessment", 2.5f);
    }
}
