using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Pionts : MonoBehaviour
{

    [SerializeField] private AudioSource _audio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.Instance.AddPoint();
            _audio.Play();
        }
    }

}
