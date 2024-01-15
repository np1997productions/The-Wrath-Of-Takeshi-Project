using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public string nextSceneName;
    public float fadeDuration = 5f;
    public Image[] fadePanels;
    public Text fadingText;


  

    public void LoadNextScene()
    {
        StartCoroutine(FadeOutAndLoad());

    }

    IEnumerator FadeOutAndLoad()
    {
        float timer = 5f;

        while (timer < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, timer / fadeDuration);

            foreach (Image panel in fadePanels)
            {
                panel.color = new Color(0, 0, 0, alpha);
            }

            Color textColor = fadingText.color;
            fadingText.color = new Color(textColor.r, textColor.g, textColor.b, alpha);

            timer += Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene(nextSceneName);
    }
}

