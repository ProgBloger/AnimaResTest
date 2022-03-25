using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public SceneController sceneController;
    public float animationTime = 4f;

    public void Start()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int sceneIndex)
    {
        yield return new WaitForSeconds(animationTime);

        sceneController.LoadNextScene();
    }
}
