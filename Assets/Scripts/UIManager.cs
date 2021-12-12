using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject pausePanel;

    private Game game;

    private bool gameIsPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        game = Object.FindObjectOfType<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame() 
    {
        if(!gameIsPaused) 
        {
            pausePanel.SetActive(true);
            gameIsPaused = true;
            Time.timeScale = 0;
        } 
        else 
        {
            pausePanel.SetActive(false);
            gameIsPaused = false;
            Time.timeScale = 1;
        }
    }

    public void QuitGame() {
        Debug.Log("quit pressed");
        Application.Quit();
    }
}
