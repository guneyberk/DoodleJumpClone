using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }
    void FixedUpdate() => Camera.main.transform.position = new Vector3(0,0,-2.5f)+Vector3.Lerp(_player.transform.position, Camera.main.transform.position, 0.5f);
}
