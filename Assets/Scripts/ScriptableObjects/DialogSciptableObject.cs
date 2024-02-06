using UnityEngine;

[CreateAssetMenu(fileName = "NewDialog", menuName = "ScriptableObjects/Dialog", order = 1)]
public class DialogSciptableObject : ScriptableObject
{
    [SerializeField]
    private string npcName;

    [SerializeField]
    private string[] dialogStrings;

    [Space]

    [SerializeField]
    private string lastLoopDialogString;

    private bool isDialogOver;
    public bool IsDialogOver { get { return isDialogOver; } }

    [SerializeField]
    private int dialogIndex = -1;

    public string GetDialogString()
    {
        if (dialogIndex + 1 >= dialogStrings.Length)
        {
            isDialogOver = true;
            return lastLoopDialogString;
        }

        dialogIndex++;
        return dialogStrings[dialogIndex];
    }

    private void OnValidate()
    {
        dialogIndex = -1;
    }
}
