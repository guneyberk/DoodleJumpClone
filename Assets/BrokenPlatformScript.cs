using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BrokenPlatformScript : MonoBehaviour
{
    public UnityEvent playerCollider;

    private void Start() => playerCollider.AddListener(DisableCollider);

    private void DisableCollider() => transform.GetComponent<Collider>().enabled = false;
}
