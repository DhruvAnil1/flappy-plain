using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
   public Player player;
   public Text scoreText;
   public Text scoreText2;
   public GameObject gameOver;
   public GameObject playButton;
   private int score;

   private void Awake()
   {
      Application.targetFrameRate = 60;

      Pause();

   }

   public void Play()
   {
      score = 0;
      scoreText.text = score.ToString();
      playButton.SetActive(false);
      gameOver.SetActive(false);
      Time.timeScale = 1f;
      player.enabled = true;

      Pipes[] pipes = FindObjectsOfType<Pipes>();

      for(int i = 0; i < pipes.Length; i++){
         Destroy(pipes[i].gameObject);
      }
   }

   public void Pause()
   {
      Time.timeScale = 0f;
      player.enabled = false;

   }

   public void GameOver()
   {
      gameOver.SetActive(true);
      playButton.SetActive(true);
      Pause();
    
   }

   public void IncreaseScore()
   {
    score++;
    scoreText.text = score.ToString();
   }

    public void IncreaseScore2()
   {
    score++;
    scoreText2.text = score.ToString();
   }
}
