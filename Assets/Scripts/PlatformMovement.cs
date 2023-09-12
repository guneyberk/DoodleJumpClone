using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlatformMovement : MonoBehaviour
{
   public static float _platformMovementSpeed = 0.1f;



    // Update is called once per frame
    void Update()
    {
        PlatformVelocity();


    }

    private void PlatformVelocity()
    {

        transform.Translate(Vector3.down * Time.deltaTime * _platformMovementSpeed, Space.World);
    }

    public void PlatformMovementSpeed()
    {
        _platformMovementSpeed *= 5f;
    }



}
