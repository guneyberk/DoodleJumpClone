using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Rigidbody2D))]
public class PlatformMovement : MonoBehaviour
{

    GameObject _player;
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        PlatformVelocity();
        PlatformDeactive();

    }

    private void PlatformDeactive()
    {
        if (_player.transform.position.y - transform.position.y >= 5f)
        {
            gameObject.SetActive(false);
        }


    }

    private void PlatformVelocity()
    {

        transform.Translate(Vector3.down * Time.deltaTime,Space.World);
    }



  
}
