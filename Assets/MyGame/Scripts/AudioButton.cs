using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    public Button button;
    public AudioSource audioSource;

    private void Start()
    {
        button.onClick.AddListener(ToggleAudio);
    }

    private void ToggleAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
    }
}