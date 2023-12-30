using UnityEngine;

public class MainCutsceneController : MonoBehaviour
{
    public float cutsceneDuration = 31.0f; // Set the desired duration in seconds

    void Start()
    {
        Invoke("ExitApplication", cutsceneDuration);
    }

    void ExitApplication()
    {
        // Exit the application
        Application.Quit();

        // Note: Application.Quit may not work in the Unity Editor; test in a built executable.
    }
}

