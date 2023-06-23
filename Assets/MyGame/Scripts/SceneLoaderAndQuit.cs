using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoaderAndQuit : MonoBehaviour
{
    public Button loadSceneButton;
    public Button quitGameButton;
    public string sceneToLoad;

    void Start()
    {
        if (loadSceneButton != null)
        {
            loadSceneButton.onClick.AddListener(LoadScene);
        }
       /* else
        {
            Debug.LogError("Load Scene Button not assigned.");
        }
       */

        if (quitGameButton != null)
        {
            quitGameButton.onClick.AddListener(QuitGame);
        }
        /*else
        {
            Debug.LogError("Quit Game Button not assigned.");
        }
        */
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}