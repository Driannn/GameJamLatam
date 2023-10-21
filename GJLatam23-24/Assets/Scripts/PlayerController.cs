using UnityEngine;

// This script applies an upwards force to the player when we press a button, resulting in a jump
public class PlayerController : MonoBehaviour
{
    // variables for a Rigidbody2D and a float that we can set in the inspector
    // public means it is shown in the inspector
    // "Rigidbody2D" and "float" are the type of variable
    // "body" and "jumpSpeed" are the custom names we give the variables
    
    // Physics body that we want to interact with
    public Rigidbody2D body;

    // Impulse strength that can be configured via Unity Editor
    public float jumpSpeed = 5;

    private void Update()
    {
        // an if statement! It will only run the code inside its body if one of the conditions inside it is true.
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            // If we press a jump button, set player's velocity to up
            body.velocity = Vector2.up * jumpSpeed;
        }
    }
}