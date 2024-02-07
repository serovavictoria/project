using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogWindow : AbstractWindowUI
{
    [SerializeField]
    private TMP_Text npcName;

    [SerializeField]
    private TMP_Text dialogText;

    [SerializeField]
    private Button nextDialogStringButton;


    private DialogSciptableObject dialog;


    public bool HasDialog { get { return dialog != null; } }

    public bool IsDialogOver {  get { return dialog.IsDialogOver; } }

    public event Action OnGetNextDialogString;

    private void Start()
    {
        OnGetNextDialogString += GetNextDialogString;
        nextDialogStringButton.onClick.AddListener(OnGetNextDialogString.Invoke);
    }

    public override void OpenWindow()
    {
        base.OpenWindow();
        if (dialogText != null) { dialogText.text = dialog.GetDialogString(); }
        if (npcName != null) { npcName.text = dialog.NpcName; }
    }

    public void GetNextDialogString()
    {
        if (dialogText != null) { dialogText.text = dialog.GetDialogString(); }
    }

    public void LoadDialog(DialogSciptableObject obj)
    {
        dialog = obj;
    }
}
