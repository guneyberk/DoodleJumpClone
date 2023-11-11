using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] _spawnPoints;
    [SerializeField] List<GameObject> _spawnList;
    GameObject _player;
    public static int _platformCount = 60;

    [ContextMenu("SpawnPlatforms")]
    private void Start()
    {
        _player = GameObject.Find("Player");
        foreach (var item in _spawnPoints)
        {
            for (int i = 0; i < _platformCount / 2; i++)
            {
                int rndPlatform = Random.Range(0, item.transform.childCount);
                if (item.transform.GetChild(rndPlatform).gameObject.activeInHierarchy)
                {
                    _spawnList.Add(ObjectPooling.Instance.SpawnFromPool("Platfrom", item.transform.GetChild(rndPlatform).transform.position, Quaternion.identity));
                    item.transform.GetChild(rndPlatform).gameObject.SetActive(false);

                }
            }

        }
    }

    private void FixedUpdate()
    {

        SpawnPoints();

    }

    private void SpawnPoints()
    {

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Vector3 relativepos = _spawnPoints[i].transform.position - _player.transform.position;
            if (Vector3.Dot(_player.transform.up, relativepos) <= -4.5f)
            {
                float spawnPointDistance = PositionSpawnPoints();
                _spawnPoints[i].transform.position = new Vector3(0, spawnPointDistance + 5f, 0);

                SpawnPlatforms(i);

            }
        }
    }

    void SpawnPlatforms(int j)
    {
        for (int i = 0; i < _spawnPoints[j].transform.childCount; i++)
        {
            if (!_spawnPoints[j].transform.GetChild(i).gameObject.activeInHierarchy)
            {
                _spawnPoints[j].transform.GetChild(i).gameObject.SetActive(true);
            }

        }


        for (int i = 0; i < _platformCount / 2; i++)
        {
            int rndPlatform = Random.Range(0, _spawnPoints[j].transform.childCount);
            if (_spawnPoints[j].transform.GetChild(rndPlatform).gameObject.activeInHierarchy)
            {
                ObjectPooling.Instance.SpawnFromPool("Platfrom", _spawnPoints[j].transform.GetChild(rndPlatform).transform.position, Quaternion.identity);
                _spawnPoints[j].transform.GetChild(rndPlatform).gameObject.SetActive(false);
                GameManager.score++;
            }
            else
            {
                rndPlatform = Random.Range(0, _spawnPoints[j].transform.childCount);
                ObjectPooling.Instance.SpawnFromPool("Platfrom", _spawnPoints[j].transform.GetChild(rndPlatform).transform.position, Quaternion.identity);
                _spawnPoints[j].transform.GetChild(rndPlatform).gameObject.SetActive(false);
                GameManager.score++;

            }
        }
    }


    public float PositionSpawnPoints()
    {
        float spawnPointDistance = 0;
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Vector3 relativePos = _spawnPoints[i].transform.position - _player.transform.position;
            if (Vector3.Dot(_player.transform.up, relativePos) >= spawnPointDistance)
            {
                spawnPointDistance = _spawnPoints[i].transform.position.y;

            }

        }
        return spawnPointDistance;

    }


}
