using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter2D : MonoBehaviour
{
    public UnityEvent OnEnter;


    private void OnTriggerEnter(Collider other)
    {
        OnEnter?.Invoke();
    }
}
