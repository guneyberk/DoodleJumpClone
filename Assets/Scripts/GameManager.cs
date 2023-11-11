using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Numerics;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text gameOverText;
    [SerializeField] Button resetButton;
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    private GameObject _playerMovS;
    public static int score;
    private int _highScore = 0;

    [SerializeField] UnityEvent _ostEvents;
    


    private void Start()
    {
        _playerMovS = GameObject.Find("Player/PlayerSprite");
        score = 0;
    }
    private void Update()
    {

        UpdateScore();
        
    }


    void UpdateScore()
    {
        scoreText.text = score.ToString();

        

        if (PlayerPrefs.HasKey("hScore")){
            if (score >= PlayerPrefs.GetInt("hScore"))
            {
                _highScore = score;
                PlayerPrefs.SetInt("hScore", _highScore);
                PlayerPrefs.Save();
            }
        }

        else if (score >= _highScore)
        {
            {
                _highScore = score;
                PlayerPrefs.SetInt("hScore", _highScore);
                PlayerPrefs.Save();
            }

        }
        highScoreText.text = "High Score\n"+PlayerPrefs.GetInt("hScore").ToString();
    }
    
    public void GameOver()
    {
        _ostEvents.Invoke();
        gameOverText.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(true);
        _playerMovS.SetActive(false);


    }

    public void Reset()
    {
        int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneBuildIndex);
    }



}
