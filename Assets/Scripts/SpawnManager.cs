using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] simplePlatforms;

    int _activePlatformCount = 30;
    float _midPlatformVector = Mathf.Infinity;
    GameObject _midPlatform;

    static int arrayPlatform = 0;
    GameObject _player;

    private void Awake()
    {
        for (int i = 0; i < _activePlatformCount; i++)
        {
            int j = Random.Range(0, simplePlatforms[0].transform.childCount);
            simplePlatforms[0].transform.GetChild(j).gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        for (int k = 0; k < simplePlatforms.Length; k++)
        {
            if (Vector3.Distance(_player.transform.position, simplePlatforms[k].transform.position) <= _midPlatformVector)
            {
                Debug.Log(k);
                _midPlatformVector = Vector3.Distance(_player.transform.position, simplePlatforms[k].transform.position);
                _midPlatform = simplePlatforms[k];

            }
            if (Vector3.Distance(_player.transform.position, _midPlatform.transform.position) <= 4f)
            {
                ActivatePlatform();
            }
        }
    }
    private void Start()
    {
        _player = GameObject.Find("Player");
        _player.transform.position = new Vector3(0,1,0);
    }


    private void ActivatePlatform()
    {
        for (int i = 0; i < simplePlatforms[arrayPlatform].transform.childCount; i++)
        {
            simplePlatforms[arrayPlatform].transform.GetChild(i).gameObject.SetActive(false);
        }

        simplePlatforms[arrayPlatform].transform.position = new Vector3(0, _midPlatform.transform.position.y + 8f, 0);
        for (int i = 0; i < _activePlatformCount; i++)
        {
            int j = Random.Range(0, simplePlatforms[arrayPlatform].transform.childCount);
            simplePlatforms[arrayPlatform].transform.GetChild(j).gameObject.SetActive(true);
        }
    }

}
