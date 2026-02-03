using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    public int Points { get; private set; }

    public delegate void NewScore(int newScore);
    public event NewScore OnNewScore;

    private void Awake()
    {
        if (Instance != null && Instance != this) 
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }


    public void AddPoint()
    {
        Points++;
        OnNewScore?.Invoke(Points);
    }
}
