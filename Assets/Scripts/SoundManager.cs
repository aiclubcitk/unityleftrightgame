using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource wrongSound;
    public AudioSource correctSound;
    public AudioSource gameOverSound;
    public AudioSource gameStartSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayWrongSound(){
        wrongSound.Play();
    }
    public void PlayCorrectSound(){
        correctSound.Play();
    }
    public void PlayGameOverSound(){
        gameOverSound.Play();
    }
    public void PlayGameStartSound(){
        gameStartSound.Play();
    }
    
}
