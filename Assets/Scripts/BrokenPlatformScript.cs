using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;

public class BrokenPlatformScript : MonoBehaviour
{
    float _gravityScale = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = _gravityScale;
        }
        
    }
    


}
