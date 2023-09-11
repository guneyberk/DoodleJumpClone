using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class PlayerCamera : MonoBehaviour
{
    private GameObject _player;
    private Vector3 _lerpedPosition;
    private float _oldPosition;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }
    void FixedUpdate()
    {

        if (Camera.main.transform.position.y <= _player.transform.position.y)
        {
            _lerpedPosition = new Vector3(0, 0, -2.5f) + Vector3.Lerp(_player.transform.position, Camera.main.transform.position, 0.1f);
            Camera.main.transform.position = new Vector3(0, _lerpedPosition.y, _lerpedPosition.z);

        }

    }
}
