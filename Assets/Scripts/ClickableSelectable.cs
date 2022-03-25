using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableSelectable : MonoBehaviour
{
    public Animator fadeAwayAnimation;
    private TranscendToNextScene transcend;

    void Start()
    {
        transcend = GetComponent<TranscendToNextScene>();
    }

    public void OnMouseDown()
    {
        Debug.Log("clicked");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) 
            {
                Debug.Log(hit.collider.gameObject.name);
                transcend.MoveToNextScene();
            }
            // TODO: Implement in an event system for messaging
            // else
            // {
            //     Debug.Log("This circle isn't selected");
            //     fadeAwayAnimation.SetTrigger("Start");
            // }
            // Destroy not selected spheres
        // On the next scene the object gets destroyed when the reset button is called
        }
    }
}
