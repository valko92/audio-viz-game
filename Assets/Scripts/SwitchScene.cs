using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Animator SceneFader;
    public string Scene;
    public void GoToScene()
    {
        StartCoroutine(LoadMainScene(Scene));
    }
    IEnumerator LoadMainScene(string newScene)
    {
        SceneFader.SetTrigger("StartFadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(newScene);
    }
}
