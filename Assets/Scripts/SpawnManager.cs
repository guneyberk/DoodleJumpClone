using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject _spawnPoints;
    [SerializeField] GameObject _spawnPointsFirst;
    GameObject _player;
    List<GameObject> _platform = new List<GameObject>();
    int _activePlatformCount = 30;
   


    private void Start()
    {
        _player = GameObject.Find("Player");

        for (int i = 0; i < _activePlatformCount; i++)
        {
            GameObject platform = ObjectPooling.instance.GetPooledObjects();

            if (platform != null)
            {
                int j = Random.Range(0, _spawnPoints.transform.childCount);
                platform.transform.position = _spawnPointsFirst.transform.GetChild(j).transform.position;
                platform.SetActive(true);
                _platform.Add(platform);


            }

        }
    }

    private void Update()
    {
        for (int i = 0; i < _platform.Count; i++)
        {
            if (!_platform[i].activeInHierarchy)
            {
                SpawnPlatforms();
            }

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
            _spawnPoints.transform.GetChild(j).gameObject.SetActive(false);
            _platform.Add(platform);
            


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
                
            }
        }
    }
    private void SpawnPointsFollow() => _spawnPoints.transform.position = new Vector3(0, Camera.main.transform.position.y, 0);
}
