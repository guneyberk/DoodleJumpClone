using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColliderScript : MonoBehaviour
{
    GameObject _player;
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        gameObject.GetComponent<BoxCollider2D>().enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        ActivateCollider();
    }

    private void ActivateCollider()
    {
        if (_player.transform.position.y>= transform.position.y + 0.25)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if(_player.transform.position.y <= transform.position.y -0.25)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    
}
