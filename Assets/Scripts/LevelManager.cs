using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelManager : MonoBehaviour
{
    public int Score;
    [SerializeField]private Spawner spawner;
    [SerializeField]private GameObject GameOverPanel;
    // Start is called before the first frame update
    [SerializeField]private TextMeshProUGUI scoreText;
    [SerializeField]private TextMeshProUGUI TimeText;
    public AudioSource gameOverSound;
   void Awake()
    {
        Time.timeScale = 1;
    }
    public void GameOver(){
        // Game Over
        GameOverPanel.SetActive(true);
        scoreText.text = "Score: " + Score;
        TimeText.text = "Time: " + Time.timeSinceLevelLoad+" seconds";
        spawner.canSpawn = false;
        gameOverSound.Play();
    }
    public void AddScore(int score){
        Score += score;
    }
    
}
