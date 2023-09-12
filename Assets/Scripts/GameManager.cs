using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text gameOverText;
    public Text scoreText;
    private float _scoreMultiplirer = 1f;
    public UnityEvent _platformSpeedEvent;
    private float newScore = 100;

    private void Update()
    {
        UpdateScore();
    }

   
    void UpdateScore()
    {

        float score = ((short)Time.time) * _scoreMultiplirer;
        scoreText.text = "Score: " + score;

        if (score >= newScore)
        {
            newScore *= 10;
            _scoreMultiplirer *= 2;
            UpdatePlatformSpeed();
        }
       
            

    }
    void UpdatePlatformSpeed()
    {
      _platformSpeedEvent.Invoke();

    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;

    }



}
