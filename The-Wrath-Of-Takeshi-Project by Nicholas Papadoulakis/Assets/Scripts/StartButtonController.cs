using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonController : MonoBehaviour
{
    public Button myButton;
    public float appearanceDelay = 4f;
    public float disappearanceDelay = 20f;
    public string nextScene = "NextScene";


    void Start()
    {
        myButton.gameObject.SetActive(false); // Ensure the button is initially hidden

        Invoke("ShowButton", appearanceDelay);
        Invoke("HideButton", disappearanceDelay);
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
        SceneManager.LoadScene(nextScene);
    }
}

