using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int MaximumGuess = 1000;
    int LowestGuess = 1;
    int CurrentGuess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number you can pick is " + MaximumGuess);
        Debug.Log("The lowest number you can pick is " + LowestGuess);
        Debug.Log("Tell me if your number is higher or lower than " + CurrentGuess);
        Debug.Log("Push up = higher, push down = lower, push enter = correct");
    }

    void ResetGame()
    {
        MaximumGuess = 1000;
        LowestGuess = 1;
        CurrentGuess = 500;
        StartGame();
    }

    void CalculateGuess()
    {
        CurrentGuess = (MaximumGuess + LowestGuess +1) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //Detecting user input
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                LowestGuess = CurrentGuess;
                CalculateGuess();
                Debug.Log("Is your number higher or lower than" + CurrentGuess);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MaximumGuess = CurrentGuess;
                CalculateGuess();
                Debug.Log("Is your number higher or lower than" + CurrentGuess);
            }
            else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                Debug.Log(CurrentGuess + " is the number you guessed.");
                ResetGame();
            }
            else
            {
                Debug.Log("Please only use the up arrow, down arrow, and enter/return keys");
            }
        }

    }
}
