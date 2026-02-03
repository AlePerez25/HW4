using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] GameObject _pipe;

    float time = 0f;
    float repeticion = 4f;

    void Start()
    {
        Spawn();
    }    

    // esto indieca cada cunato se va a regenrar.
    void Update()
    {
        time += Time.deltaTime;
        if (time >= repeticion)
        {
            Spawn();
            time = 0f;
        }
    }
    
    // Es basicamente lo mismo que el mg2 pero no se utilizo un loop esta ves 
    // porque no queremos que tengan ceperaciones distintas ni que este en una sola linea
    // queremos que tenga una ceparacion especifica y que no cambie.
    void Spawn()
    {
        // Esta ves en el que usamos "Random.Range" fue en el ege "y" 
        // porque lo que queriamos que cambiera de pocicion era este eje y no el x.

        float y = Random.Range(2.5f, 7.3f);
        float x = 8.0f;

        Vector3 pos = new Vector3(x, y, 0);
        Instantiate(_pipe, pos, Quaternion.identity);

        //esto es para indicar uin min y max de separacion
        x += Random.Range(1.0f, 2.0f);
    } 

    

}
