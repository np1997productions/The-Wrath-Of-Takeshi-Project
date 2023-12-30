using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    public float cutsceneDuration = 5.0f; // Set the desired duration in seconds
    public string nextScene = "NextScene"; // Replace with the name of your next scene

    void Start()
    {
        Invoke("LoadNextScene", cutsceneDuration);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}


