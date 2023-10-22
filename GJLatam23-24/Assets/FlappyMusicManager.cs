using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMusicManager : MonoBehaviour
{
    //instance para hacer este game obj como DontDestroyOnLoad
    public static FlappyMusicManager Instance;
    public FMODUnity.StudioEventEmitter studioEventEmitter;
    public int IsNewHighScore;
    public int ActiveScene;
    public int IsPaused;

    void Awake()
    {
        //Dont destroy on load, la musica va sonar en cada escena del juego desde este game object
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void MusicOnPause(int pause)
    {
        studioEventEmitter.SetParameter("Paused game", pause);
    }
}
