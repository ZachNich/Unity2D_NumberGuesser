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
        max++;
    }
    
    public void OnPressHigher()
    {
        min = guess + 1;
        CalcGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        CalcGuess();
    }

    void CalcGuess()
    {
        if (min < max) guess = UnityEngine.Random.Range(min, max);
        GuessText.text = guess.ToString();
    }
}
