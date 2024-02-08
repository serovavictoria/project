using Assets.Scripts;
using UnityEngine;

public class TeacherDialogTrigger : MonoBehaviour
{
    [SerializeField]
    private DialogSciptableObject dialog;

    [SerializeField]
    private EndGameWindow endGameWindow;

    private DialogQuestController dialogQuestController;

    private void Start()
    {
        dialogQuestController = FindAnyObjectByType<DialogQuestController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetFloat("assessment") < 2.5)
        {
            dialogQuestController.Load(dialog, null);
        }
        else
        {
            endGameWindow.OpenWindow();
        }
        

    }

}
