using Assets.Scripts.UI;
using Scripts;
using UnityEngine;

namespace Assets.Scripts
{
    public class DialogQuestController : MonoBehaviour
    {
        [SerializeField]
        private DialogWindow dialogWindow;

        [SerializeField]
        private QuestWindow questWindow;

        private Player player;

        private void Awake()
        {
            player = GameObject.FindAnyObjectByType<Player>();

            dialogWindow.OnGetNextDialogString += GetNextDialogString;
            questWindow.OnSendAnswer += SendAnswer;
        }

        public void Load(DialogSciptableObject dialog, QuestScriptableObject quest)
        {
            if (quest != null && quest.IsComplete || !quest.CanCompleteQuest) { return; }

            dialogWindow.LoadDialog(dialog);
            questWindow.LoadQuest(quest);

            StartUsingWindows();
        }

        private void StartUsingWindows()
        {
            player.enabled = false;
            dialogWindow.OpenWindow();
        }

        private void GetNextDialogString()
        {
            if (dialogWindow.IsDialogOver && !questWindow.HasQuest)
            {
                EndUsingWindows(dialogWindow);
            }
            else if (dialogWindow.IsDialogOver && questWindow.HasQuest) 
            { 
                dialogWindow.CloseWindow();
                questWindow.OpenWindow();
            }
        }

        private void SendAnswer()
        {
            if (questWindow.IsQuestComplete)
            {
                EndUsingWindows(questWindow);
            }
        }

        private void EndUsingWindows(AbstractWindowUI window)
        {
            window.CloseWindow();
            player.enabled = true;
        }
    }
}