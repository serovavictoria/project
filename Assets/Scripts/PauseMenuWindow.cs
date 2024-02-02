using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuWindow : AbstractWindowsUI
{
    [SerializeField]
    private GameObject pauseMenuPanel;

    [SerializeField]
    private Player player;

    private bool isPaused;

    public void Pause()
    {
        isPaused = true;
        OpenWindows();
        Time.timeScale = 0f;
        player.enabled = false; 
    }

    public void Resume()
    {
        isPaused = false;   
        CloseWindows();
        Time.timeScale = 1f;
        player.enabled = true;
    }

    public override void OpenWindows()
    {
        pauseMenuPanel.SetActive(true);
    }

    public override void CloseWindows()
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
