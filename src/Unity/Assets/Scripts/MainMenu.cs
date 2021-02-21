using System.Collections; 
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation ope = SceneManager.LoadSceneAsync(sceneIndex);
        while (!ope.isDone)
        {
            // Debug.Log(ope.progress); affiche la progression du chargement de la scene
            yield return null;
        }
    }
}
