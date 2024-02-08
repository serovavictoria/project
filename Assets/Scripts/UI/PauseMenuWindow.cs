using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuWindow : AbstractWindowUI
{
    [SerializeField]
    private GameObject pauseMenuPanel;

    [SerializeField] private AssessmentController assessmentController;

    [SerializeField]
    private Player player;

    private bool isPaused;

    public void Pause()
    {
        isPaused = true;
        OpenWindow();
        Time.timeScale = 0f;
        player.enabled = false;

        assessmentController.gameObject.SetActive(false);
    }

    public void Resume()
    {
        isPaused = false;   
        CloseWindow();
        Time.timeScale = 1f;
        player.enabled = true;

        assessmentController.gameObject.SetActive(true);
    }

    public override void OpenWindow()
    {
        pauseMenuPanel.SetActive(true);
    }

    public override void CloseWindow()
    {
        pauseMenuPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }    
        }
    }
}
