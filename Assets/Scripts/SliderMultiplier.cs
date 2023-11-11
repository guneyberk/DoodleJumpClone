using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SliderMultiplier : MonoBehaviour
{
    int _count = 0;
    private GameObject _slider;
    GameObject _player;
    Animator _animatorPlayer;
    [SerializeField]  Animator _animatorW;
    [SerializeField] ParticleSystem _particleSystem;
    [SerializeField] UnityEvent _starterEvent;

    private void Start()
    {
        
        _player =GameObject.Find("Player/PlayerSprite");
        _slider = GameObject.Find("StartMultiplier/Slider");
        _animatorPlayer = _player.GetComponent<Animator>();

    }
    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.W)&&_count<=2)
        {
            _count++;
            switch (_count)
            {
                
                case 1:
                    _animatorPlayer.SetFloat("Speed", 0.2f);
                    _slider.transform.localPosition = new Vector2(0, 1);
                    break;
                case 2:
                    _animatorPlayer.SetFloat("Speed", 0.5f);
                    _slider.transform.localPosition = new Vector2(0, 1.5f);
                    break;
                case 3:
                    _animatorW.SetTrigger("Wfade");
                    _slider.transform.localPosition = new Vector2(0, 1.7f);
                    _particleSystem.Play();
                    _animatorPlayer.enabled=false;
                    _starterEvent.Invoke();
                    break;
                default:
                    _animatorPlayer.SetFloat("Speed", 0.01f);
                    _slider.transform.localPosition = new Vector2(0, -1.5f);
                    break;

            }
            
           
        }
        else if(Input.GetKeyDown(KeyCode.S)&& _count >= 1)
        {
            _count--;
            switch (_count)
            {

                case 1:
                    _animatorPlayer.SetFloat("Speed", 0.2f);
                    _slider.transform.localPosition = new Vector2(0, 1);
                    break;
                case 2:
                    _animatorPlayer.SetFloat("Speed", 0.5f);
                    _slider.transform.localPosition = new Vector2(0, 1.5f);
                    break;
                case 3:
                    _animatorPlayer.SetFloat("Speed", 1f);
                    _slider.transform.localPosition = new Vector2(0, 1.7f);
                    break;
                default:
                    _animatorPlayer.SetFloat("Speed", 0.01f);
                    _slider.transform.localPosition = new Vector2(0, -1.5f);
                    break;

            }
        }
    }
}
