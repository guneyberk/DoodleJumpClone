using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }


    private void OnBecameInvisible()
    {
        if (_player != null)
        {
            Debug.Log("GameOver");

        }
    }
}
