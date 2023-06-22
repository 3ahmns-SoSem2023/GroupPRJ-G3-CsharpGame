using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpResetScript : MonoBehaviour
{
    public Text Hilfe;
    public int currentIndexHelp;
    public Canvas activator;
    string Aufgabe2 = "The right answer is:                 if( number = 0 )            {                          Debug.Log(0);                        }";
    string Aufgabe3 = "The right answer is:                  if( zahl == 0)               {                       Debug.Log(''Hilfe'');                 } ";
    // Start is called before the first frame update
    void Start()
    {
        currentIndexHelp = 0;
    }

    public void Questions()
    {
        Hilfe.enabled = false;
        currentIndexHelp++;
        if (currentIndexHelp == 1)
        {
            Hilfe.text = Aufgabe2;
        }
        else if (currentIndexHelp == 2)
        {
            Hilfe.text = Aufgabe3;
        }
        else
        {
            activator.enabled = false;
        }


    }
}
