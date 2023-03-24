using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUI : MonoBehaviour
{
    [SerializeField]private LevelManager levelManager;
    [SerializeField]private Player player;
    [SerializeField]private TextMeshProUGUI scoreText;
    [SerializeField]private TextMeshProUGUI livesText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + levelManager.Score;
        livesText.text = "Lives: " + player.Lives;
    }
}
