using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpScript : MonoBehaviour
{
    public Text Hilfe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HelpMethod()
    {
        if (Hilfe.isActiveAndEnabled)
        {
            Hilfe.enabled = false;
            Debug.Log("deaktviert");
        }
        else
        {
            Hilfe.enabled = true;
            Debug.Log("aktiviert");
        }
    }
}
