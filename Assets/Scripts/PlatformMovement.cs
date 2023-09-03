using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(PlatformMovement))]
public class PlatformMovement : MonoBehaviour
{

    GameObject _player;
    private Vector2 _playerVelocity;

    void Start()
    {
        _player = GameObject.Find("Player");
        //transform.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
          _playerVelocity = _player.GetComponent<Rigidbody2D>().velocity;

         transform.position = -_player.transform.position;

    }
}
