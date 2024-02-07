using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDialog", menuName = "ScriptableObjects/Dialog", order = 1)]
public class DialogSciptableObject : ScriptableObject
{
    [SerializeField]
    private DialogString[] dialogStrings;

    [Space]

    private bool isDialogOver;
    public bool IsDialogOver { get { return isDialogOver; } }

    private int dialogIndex = -1;

    public DialogString GetDialogString()
    {
        dialogIndex++;

        if (dialogIndex + 1 >= dialogStrings.Length)
        {
            isDialogOver = true;
            dialogIndex = dialogStrings.Length - 1;
        }

        return dialogStrings[dialogIndex];
    }

    private void OnEnable()
    {
        isDialogOver = false;
        dialogIndex = -1;
    }
}
