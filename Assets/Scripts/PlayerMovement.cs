using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float _jumpPower;
    [SerializeField] float _horizontalPower;
    Rigidbody2D _playerRb;
    float horizontalInput;

    public Text _gameOverText;


    void Start()
    { 
        _playerRb = transform.GetComponent<Rigidbody2D>();
        _playerRb.velocity += Vector2.up * _jumpPower;
    }
    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            _playerRb.velocity += Vector2.up * _jumpPower;
        }
    }

    private void Update()
    {
        HorizontalMovement();

    }
    void HorizontalMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * _horizontalPower;
        _playerRb.velocity += new Vector2(horizontalInput, 0);
    }

    private void OnBecameInvisible()
    {

        _gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;

    }
}
