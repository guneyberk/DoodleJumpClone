using UnityEngine;
public class PlatformMovement : MonoBehaviour
{

    GameObject _player;
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //PlatformVelocity();


    }

    private void PlatformVelocity()
    {

        transform.Translate(Vector3.down * Time.deltaTime, Space.World);
    }




}
