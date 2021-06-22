using System;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            HandleGuess();
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            HandleGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct");
            StartGame();
        }
    }

    void StartGame()
    {
        max = 420;
        min = 69;
        CalcGuess();
        Debug.Log("Greetings, young player.");
        Debug.Log("Pick a number, should you dare.");
        Debug.Log($"The highest option is {max}.");
        Debug.Log($"The lowest option is {min}.");
        Debug.Log($"Tell me if your number is higher or lower than {guess}");
        Debug.Log($"Up Arrow = Higher; Down Arrow = Lower; Enter = Correct");
        max++;
    }

    void HandleGuess()
    {
        CalcGuess();
        Debug.Log($"Higher or lower than {guess}?");
    }

    void CalcGuess()
    {
        guess = (max + min) / 2;
    }
}
