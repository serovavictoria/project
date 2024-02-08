using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSchool : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetFloat("assessment") < 2.5) return;

        SceneManager.LoadScene(1);
    }
}