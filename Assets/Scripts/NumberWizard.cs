using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI GuessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        CalcGuess();
    }
    
    public void OnPressHigher()
    {
        if (guess + 1 < max) min = guess + 1;
        else min = guess;
        CalcGuess();
    }

    public void OnPressLower()
    {
        if (guess - 1 > min) max = guess - 1;
        else max = guess;
        CalcGuess();
    }

    void CalcGuess()
    {
        guess = UnityEngine.Random.Range(min, max + 1);
        GuessText.text = guess.ToString();
    }
}
