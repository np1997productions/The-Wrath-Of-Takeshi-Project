using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonController : MonoBehaviour
{
    public Button myButton;
    public float appearanceDelay = 4f;
    public float disappearanceDelay = 20f;
    public string nextScene = "NextScene";
    public AudioClip buttonClickSound; // Add this line
    private AudioSource audioSource; // Add this line

    void Start()
    {
        myButton.gameObject.SetActive(false); // Ensure the button is initially hidden

        Invoke("ShowButton", appearanceDelay);
        Invoke("HideButton", disappearanceDelay);

        audioSource = gameObject.AddComponent<AudioSource>(); // Add this line to add AudioSource component
    }

    void ShowButton()
    {
        myButton.gameObject.SetActive(true);
    }

    void HideButton()
    {
        myButton.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        PlayButtonClickSound(); // Play sound before loading the scene
        SceneManager.LoadScene(nextScene);
    }

    void PlayButtonClickSound()
    {
        if (audioSource != null && buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }
    }
}

