using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    // Start is called before the first frame update
    public static ObjectPooling instance;

    private List<GameObject> pooledObjects= new List<GameObject>();
    private int amountToPool = 50;

    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private GameObject brokenPlatformPrefab;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    void Start()
    {
          
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject simplePlatform = Instantiate(platformPrefab);
            simplePlatform.SetActive(false);

            pooledObjects.Add(simplePlatform);
        }
    }
    public GameObject GetPooledObjects()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
  
}
