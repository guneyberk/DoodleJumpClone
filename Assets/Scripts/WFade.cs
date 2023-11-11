using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WFade : MonoBehaviour
{
    // Start is called before the first frame update
    private void Disable()
    {
       gameObject.SetActive(false);
    }
}
