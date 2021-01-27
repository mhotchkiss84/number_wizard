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
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number you can pick is " +MaximumGuess);
        Debug.Log("The lowest number you can pick is "+ LowestGuess);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = higher, push down = lower, push enter = correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //Detecting user input
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Up Arrow key was pressed.");
                LowestGuess = CurrentGuess;
                Debug.Log(CurrentGuess);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("Down Arrow key was pressed.");
                MaximumGuess = CurrentGuess;
                Debug.Log(CurrentGuess);

            }
            else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                Debug.Log("Return key was pressed.");
            }
            else
            {
                Debug.Log("Please only use the up arrow, down arrow, and enter/return keys");
            }
        }

    }
}
