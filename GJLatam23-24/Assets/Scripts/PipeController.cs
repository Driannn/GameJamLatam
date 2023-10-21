using System;
using UnityEngine;


public class PipeController : MonoBehaviour
{
    // When this pipe is past this left bound, it will respawn
    public float leftXBound = -10;
    // When this pipe respawns, it will appear at this right bound
    public float rightXBound = 20;
    // The pipe moves this many units per second
    public float speed = -2;
    
    // Update is called once every frame
    public void Update()
    {
        // Move on the x axis every frame
        transform.Translate(speed * Time.deltaTime, 0, 0);

        // This is an if statement! It will only run the code inside its body if the condition is has is true.
        // In this case, it will only run if this pipe controller moved past the left bound
        if (transform.position.x < leftXBound)
        {
            Vector3 newPosition = transform.position;
            newPosition.x = rightXBound;
            transform.position = newPosition;
        }
    }
}
