using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Settings settings;


    // Start is called before the first frame update
    void Start()
    {
        Music music = Object.FindObjectOfType<Music>();
        settings = Object.FindObjectOfType<Settings>();

        if (music)
        {
            music.playMainMenuMusic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void playGame()
    {
        SceneManager.LoadScene("main");
    }
}
