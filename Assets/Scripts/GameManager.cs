using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject _player;
    public Text _gameOverText;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }


   
}
