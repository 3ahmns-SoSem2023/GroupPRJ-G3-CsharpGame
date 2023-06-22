using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTextInput : MonoBehaviour
{
    public InputField inputField;

    public void ResetInputField()
    {
        inputField.text = string.Empty;
    }
}
