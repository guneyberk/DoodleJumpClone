using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float _jumpPower;
    [SerializeField] float _horizontalPower;
    [SerializeField] ParticleSystem _dustParticle;
    Rigidbody2D _playerRb;
    float _startPower =2.5f;
    public UnityEvent gameOverScreen;
    AudioSource _SFXAudio;
    [SerializeField] AudioClip _jumpAudio;
    [SerializeField] AudioClip _deathAudio;


    void Start()
    {
        _playerRb = transform.GetComponent<Rigidbody2D>();
        _SFXAudio = gameObject.GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            _SFXAudio.clip = _jumpAudio;
            _SFXAudio.Play();
            _dustParticle.Play();
            _playerRb.velocity += Vector2.up * _jumpPower;
        }
        
    }

    private void FixedUpdate()
    {
        HorizontalMovement();
      
    }
   


    void HorizontalMovement()
    {
            _playerRb.velocity += new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * _horizontalPower, 0);


    }

    

    public void StartPush()
    {
        _playerRb.velocity += Vector2.up * _jumpPower*_startPower ; 
    }
    private void OnBecameInvisible()
    {
        _SFXAudio.clip = _deathAudio;
        _SFXAudio.Play();  
        gameOverScreen.Invoke();
    }



}

