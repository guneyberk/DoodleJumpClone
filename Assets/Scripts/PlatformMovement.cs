using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlatformMovement : MonoBehaviour
{
    public Text _gameOverText;



    // Update is called once per frame
    void Update()
    {
        PlatformVelocity();


    }

    private void PlatformVelocity()
    {

        transform.Translate(Vector3.down * Time.deltaTime, Space.World);
    }

    



}
