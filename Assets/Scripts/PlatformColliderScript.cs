using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class PlatformColliderScript : MonoBehaviour
{
   [SerializeField] GameObject _player;
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        gameObject.GetComponent<Collider2D>().enabled = false;   
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
            gameObject.GetComponent<Collider2D>().enabled = true;
        }
        else if(_player.transform.position.y <= transform.position.y -0.25)
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
}
