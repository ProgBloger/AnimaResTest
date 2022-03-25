using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranscendToNextScene : MonoBehaviour
{
    private bool _movingToCenter = false;

    public int speed = 5;
    public SceneController sceneController;

    // Update is called once per frame
    void Update()
    {
        if(_movingToCenter)
        {
            // Selected Sphere moves to the center

            Debug.Log("A step to the center");
            var screenCenter = new Vector3(0, 0, 0);
            var t = Vector3.Lerp(transform.position, screenCenter, Time.deltaTime * speed);

            if (Vector3.Distance (transform.position, screenCenter) < 0.02)
            {
                Debug.Log("Made it to the center");
                _movingToCenter = false;
                SwitchToNextScene();
            }
        }
    }

    public void MoveToNextScene() 
    {
        Debug.Log("Movieng to the center");
        _movingToCenter = true;
    }
    
    void SwitchToNextScene()
    {
        Debug.Log("Switching to the next scene");
        // Dont destory on load is called
        DontDestroyOnLoad(this.gameObject);
        // Next scene is loaded
        sceneController.LoadNextScene();
    }
}
