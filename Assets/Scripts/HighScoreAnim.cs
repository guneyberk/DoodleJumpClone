using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScoreAnim : MonoBehaviour
{
    [SerializeField] Text _highScoreText;

    void EndOfAnim()
    {
        _highScoreText.GetComponent<Animator>().SetTrigger("HighScoreTrigger");
    }
}
