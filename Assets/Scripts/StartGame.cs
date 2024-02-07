using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void Start()
    {
        PlayerPrefs.SetFloat("assessment", 2.5f);
    }
}
