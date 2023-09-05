using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] simplePlatforms;

    int _activePlatformCount = 10;

    static int arrayPlatform = 0;

    private void Awake()
    {


        for (int i = 0; i < _activePlatformCount; i++)
        {

            int j = Random.Range(0, simplePlatforms[arrayPlatform].transform.childCount);

            simplePlatforms[arrayPlatform].transform.GetChild(j).gameObject.SetActive(true);

        }

    }


    public void ActivatePlatform()
    {
        //arrayPlatform++;
        simplePlatforms[arrayPlatform].transform.position = new Vector3(1, 2.125f, 0);
        int j = Random.Range(0, simplePlatforms[arrayPlatform].transform.childCount);
        simplePlatforms[arrayPlatform].transform.GetChild(j).gameObject.SetActive(true);
        

    }


}
