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
        GetNextDialogString();
    }

    public void GetNextDialogString()
    {
        DialogString dialogString = dialog.GetDialogString();

        if (dialogText != null) { dialogText.text = dialogString.Message; }
        if (npcName != null) { npcName.text = dialogString.NpcName; }
    }

    public void LoadDialog(DialogSciptableObject obj)
    {
        dialog = obj;
    }
}
