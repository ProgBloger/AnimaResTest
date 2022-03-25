using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int minScene = 0;
    private int maxScene = 2;
    private int currentScene = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadNextScene(){
        if(currentScene < maxScene)
        {
            SceneManager.LoadScene(++currentScene);
        }
        else{
            LoadFirstScene();
        }
    }

    public void LoadFirstScene(){
        currentScene = minScene;
        SceneManager.LoadScene(currentScene);
    }
}
