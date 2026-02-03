using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioSource _audio2;



    private bool _isGrounded = true;
    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
            _audio2.Play();

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        string tag = collision.gameObject.tag;
        if (tag.Equals("Ground"))
        {
            _isGrounded = true;
        }

        //Detecta cuando el jugador pierde y reinicia el jugo automaticamente 
        // con ayuda de collicion, tag y trigger.
        if (tag.Equals("Pipe"))
        {
            //Este es el codigo que s eusa para restart el juego
            //no olvides indicarle a unity que lo estas llamando el parte de arriba.
            _audio.Play();
            Time.timeScale = 0f;
            //SceneManager.LoadScene(0); 
        }
        
    
    }

}
