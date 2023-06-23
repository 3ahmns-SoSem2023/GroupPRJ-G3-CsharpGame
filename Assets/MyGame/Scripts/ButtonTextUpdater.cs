using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTextUpdater : MonoBehaviour
{
  
    //public string[] texts = {"Hallo Test","Test Hallo" }; // Eine Liste von Texten, die individuell angepasst werden k?nnen
    public Text Frage;
    public Text InputText;
  

    private int currentIndex;

    public InputFieldValidation InputFieldValidation;

    private void Start()
    {
        Frage.text = "Deklariere ein If Statement welches true ausgibt wenn die Zahl a gr??er als die Zahl b ist";
        currentIndex = 0;
        // Setze den anf?nglichen Text des Textfeldes
        UpdateTextField();
    }
    public void NextQuestion()
    {
       
        Frage.text = "Schreibe ein If Statement dass 0 ausgibt wenn die Zahl gleich 0 ist";
        
        InputText.text = string.Empty;
    }

    public void OnButtonClick()
    {
        if (InputFieldValidation.QuestionChecker)
        {
            currentIndex++;



        }
        
        

        // Aktualisiere den Index, um den n?chsten Text auszuw?hlen
        //currentIndex = (currentIndex + 1) % texts.Length;
        Debug.Log("Hallo");

        // Aktualisiere das Textfeld
        //UpdateTextField();
    }
    public void Test()
    {

    }
    private void UpdateTextField()
    {
        // Setze den Text des Textfeldes auf den aktuellen Text
        //textField.text = texts[currentIndex];
    }
}
