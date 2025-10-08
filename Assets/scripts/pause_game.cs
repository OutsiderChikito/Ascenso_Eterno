using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_game : MonoBehaviour
{
    public GameObject menuPause;
    private bool gamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }

    public void pauseGame()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;
    }

    public void resumeGame()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
