using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public List<GameObject> subMenus;

    void Start()
    {
        // Stelle sicher, dass das Hauptmenü aktiv ist und alle Untermenüs deaktiviert sind
        mainMenu.SetActive(true);
        foreach (GameObject subMenu in subMenus)
        {
            subMenu.SetActive(false);
        }
    }

    public void OpenSubMenu(int index)
    {
        if (index >= 0 && index < subMenus.Count)
        {
            mainMenu.SetActive(false);
            subMenus[index].SetActive(true);
        }
        else
        {
            Debug.LogError("Invalid submenu index");
        }
    }

    public void CloseSubMenu(int index)
    {
        if (index >= 0 && index < subMenus.Count)
        {
            subMenus[index].SetActive(false);
            mainMenu.SetActive(true);
        }
        else
        {
            Debug.LogError("Invalid submenu index");
        }
    }
}