using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip mainMenuMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playMainMenuMusic()
    {
        gameObject.GetComponent<AudioSource>().clip = mainMenuMusic;
        gameObject.GetComponent<AudioSource>().Play();
    }
}
