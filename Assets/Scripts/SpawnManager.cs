using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SpawnManager : MonoBehaviour
{
    public GameObject _simplePlatforms;
    public GameObject _brokenPlatforms;

    private void Awake()
    {
       
        for (int i = 0; i < 10; i++)
        {
            
            int j=Random.Range(0, _simplePlatforms.transform.childCount);

            _simplePlatforms.transform.GetChild(j).gameObject.SetActive(true);

        }
    
    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
