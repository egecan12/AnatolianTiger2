using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadSceneAfterDelay2 : MonoBehaviour
{
    public string sceneName = "Episode2";

    void Start()
    {
        StartCoroutine(LoadAfterDelay(sceneName));
    }

    IEnumerator LoadAfterDelay(string sceneName)
    {
        while (true)
        {
            if (Input.anyKeyDown)
            {
                break;
            }

            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
}