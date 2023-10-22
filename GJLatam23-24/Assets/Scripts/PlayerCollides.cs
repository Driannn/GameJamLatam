using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollides : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    //collision player lose
    // This function is automatically called by the Unity engine once a collision is detected
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // This destroys the object
        GameManager.instance.GameOver();

        //change scene to a random one

        //change death number, not destroy on load game object with dead count
        HUD.instance.UpdateDeaths();

        //aniamtion death
        animator.SetBool("IsDead", true);

        //play fmod event
    }
}
