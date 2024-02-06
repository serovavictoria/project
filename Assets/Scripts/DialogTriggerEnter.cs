using Assets.Scripts;
using Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogTriggerEnter : MonoBehaviour
{
    [SerializeField]
    private DialogSciptableObject dialog;

    [SerializeField]
    private QuestScriptableObject quest;

    private DialogQuestController dialogQuestController;

    private void Start()
    {
        dialogQuestController = FindAnyObjectByType<DialogQuestController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        dialogQuestController.Load(dialog, quest);
    }
}
