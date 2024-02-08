using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFlat : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetFloat("assessment") < 3.5) return;

        SceneManager.LoadScene(3);

    }
}