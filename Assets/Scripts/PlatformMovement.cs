using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlatformMovement : MonoBehaviour
{

    GameObject _player;
    private Vector2 _playerVelocity;
     float _platformVelocityFroce = 5f;

    void Start()
    {
        _player = GameObject.Find("Player");
        //transform.GetComponent<Rigidbody>().useGravity = false;
        transform.GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
          _playerVelocity = _player.GetComponent<Rigidbody2D>().velocity;

        transform.position -= new Vector3(0, _playerVelocity.y * Time.deltaTime,0);

    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
