using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text TextNum;

    void Start()
    {
        GameController.Instance.OnNewScore += UpdateScore;
    }

    private void UpdateScore(int newScore)
    {
        TextNum.text = newScore.ToString();

    }

    private void OnDestroy()
    {
        if(GameController.Instance != null)
        GameController.Instance.OnNewScore -= UpdateScore;
    }



}
