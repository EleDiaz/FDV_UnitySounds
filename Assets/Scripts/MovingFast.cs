using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFast : MonoBehaviour
{

    // TODO: The idea is to run in circles modifiyng the path with a sine wave~~
    public float radius = 50;
    public float waveWidth = 50;

    // Current angle respect to the origin
    private float Angle = 0f;

    // The center point of the circle
    public Transform origin; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Move on circles
        // We can take the origin transform and apply 
        // Sin(Time.deltaTime) * waveWidth + radius
        
    }
}
