using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformActivationEvent : MonoBehaviour
{
    public UnityEvent newPlatform;
    GameObject _player;

    private void Start()
    {
        _player=GameObject.Find("Player");
    }


    private void Update()
    {


        if (Vector3.Distance(_player.transform.position, transform.position) <= 10f)
        {

            newPlatform.Invoke();
            
        }
    }
}
