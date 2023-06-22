using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldValidation : MonoBehaviour
{
    public InputField inputField;
    public string targetSequence = "1"; // Hier die vorgegebene Zahlenfolge eingeben
    public bool QuestionChecker = true;
    public Text Correct;

    private void Start()
    {
        // Hole die InputField-Komponente
        //inputField = GetComponent<InputField>();

        // Füge einen Listener für die Eingabe hinzu
        inputField.onEndEdit.AddListener(ValidateInput);
    }

  

    private void ValidateInput(string input)
  
    {
        

        {
            string inputSequence = inputField.text;

            bool isCorrect = inputSequence == targetSequence;

            if (isCorrect)
            {
                Correct.text = "Richtig";
            }
            else
            {
                Correct.text = "Falsch";
            }
        }
    }
}

