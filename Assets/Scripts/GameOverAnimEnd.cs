using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTextAnimEnd : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    void EndOfGameOverAnim()
    {
        _scoreText.GetComponent<Animator>().SetTrigger("ScoreAnimTrig");
    }
    
   
}
