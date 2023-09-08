using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] simplePlatforms;

    int _activePlatformCount = 30;
    private GameObject _currentPlatform;

    private void Awake()
    {
        for (int i = 0; i < simplePlatforms.Length; i++)
        {
            for (int k = 0; k < _activePlatformCount; k++)
            {
                int j = Random.Range(0, simplePlatforms[i].transform.childCount);
                simplePlatforms[i].transform.GetChild(j).gameObject.SetActive(true);
            }

        }
    }

 
    private void Update()
    {
        for (int i = 0; i < simplePlatforms.Length; i++)
        {
            if (simplePlatforms[i].transform.position.y <= -8f)
            {
                ActivatePlatform(i);
            }

        }
    }

  

    private void ActivatePlatform(int arrayPlatform)
    {
        for (int i = 0; i < simplePlatforms[arrayPlatform].transform.childCount; i++)
        {
            simplePlatforms[arrayPlatform].transform.GetChild(i).gameObject.SetActive(false);
        }

        simplePlatforms[arrayPlatform].transform.position = new Vector3(0, simplePlatforms[arrayPlatform].transform.position.y + 24f, 0);
        for (int i = 0; i < _activePlatformCount; i++)
        {
            int j = Random.Range(0, simplePlatforms[arrayPlatform].transform.childCount);
            simplePlatforms[arrayPlatform].transform.GetChild(j).gameObject.SetActive(true);
        }
    }

}
