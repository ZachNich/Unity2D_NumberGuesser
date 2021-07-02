using System;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void OnPressHigher()
    {
        min = guess;
        CalcGuess();
    }

    void OnPressLower()
    {
        max = guess;
        CalcGuess();
    }

    void StartGame()
    {
        CalcGuess();
        max++;
    }

    void CalcGuess()
    {
        guess = (max + min) / 2;
    }
}
