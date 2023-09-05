using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformActivationEvent : MonoBehaviour
{
    public UnityEvent newPlatform;


    private void Update()
    {
        if(transform.position.y<= 0.125f)
        {
            newPlatform.Invoke();
        }
    }
}
