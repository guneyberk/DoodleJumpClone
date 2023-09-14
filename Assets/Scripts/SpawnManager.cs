using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject _spawnPoints;
    GameObject _player;
    List<GameObject> _platform = new List<GameObject>();
    int _activePlatformCount = 10;
    int _activePlatforms = 0;

    private void Start()
    {
        _player = GameObject.Find("Player");

        for (int i = 0; i < _activePlatformCount; i++)
        {
            GameObject platform = ObjectPooling.instance.GetPooledObjects();

            if (platform != null)
            {
                int j = Random.Range(0, _spawnPoints.transform.childCount);
                platform.transform.position = _spawnPoints.transform.GetChild(j).transform.position;
                platform.SetActive(true);
                _platform.Add(platform);
                _activePlatforms++;


            }

        }
    }

    private void Update()
    {
        Debug.Log(_activePlatforms);

        if(_activePlatforms <= _activePlatformCount)
        {
            SpawnPlatforms();
        }
        SpawnPointsFollow();
        InactivatePlatforms();

    }

    private void SpawnPlatforms()
    {
        GameObject platform = ObjectPooling.instance.GetPooledObjects();

        if (platform != null)
        {
            int j = Random.Range(0, _spawnPoints.transform.childCount);
            platform.transform.position = _spawnPoints.transform.GetChild(j).transform.position;
            platform.SetActive(true);
            _platform.Add(platform);
            _activePlatforms++;


        }
    }

    private void InactivatePlatforms()
    {
        for (int i = 0; i < _platform.Count; i++)
        {
            Vector3 relativePos = _platform[i].transform.position - _player.transform.position;
            if (Vector3.Dot(_player.transform.up, relativePos) < -2.0f)
            {
                _platform[i].gameObject.SetActive(false);
                _activePlatforms--;
            }
        }
    }
    private void SpawnPointsFollow() => _spawnPoints.transform.position = new Vector3(0, Camera.main.transform.position.y, 0);
}
