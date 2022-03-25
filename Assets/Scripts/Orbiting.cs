using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting : MonoBehaviour
{
    [SerializeField]
    public int DistanceRadius = 5;
    
    [SerializeField]
    public int Angle = 20;
    [SerializeField]
    public Transform pivotObject;
    private bool _continueOrbiting = true;

    void Start()
    {
        this.transform.position = new Vector3(
            pivotObject.position.x + DistanceRadius, 
            pivotObject.position.y, 
            pivotObject.position.z);
    }

    void Update()
    {
        if(_continueOrbiting)
        {
            var rotation = this.transform.rotation;
            transform.RotateAround(pivotObject.position, Vector3.forward, Angle * Time.deltaTime);
            this.transform.rotation = rotation;
        }
    }

    public void StopOrbiting()
    {
        _continueOrbiting = false;
    }
}
