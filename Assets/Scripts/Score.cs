using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtScore;
    [SerializeField]private TMP_Text HighestScore;
    public static int actualScore = 0;
    float nextScoreToAdd = 1;
    

    private void Start()
    {
        HighestScore.text = PlayerPrefs.GetInt("SCORE", 0).ToString();
    }

    void Update()
    {
        if (Time.time - nextScoreToAdd > 1)
            nextScoreToAdd = (Time.time*10)+1;
        if (Time.time * 10 >= nextScoreToAdd)
        {
            txtScore.text = actualScore.ToString();
            actualScore++;
            nextScoreToAdd++;
        }

    }
}