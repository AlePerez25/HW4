using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pipe : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    // Este codigo estan el Prefab de pipe

    // Este es el codigo que lo mueve a la isquierda proe so se usa la palabra "left"
    // como clave. 
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
        
        if (transform.position.x < -6f)
        {
            Destroy(gameObject);
        }
    }

}
