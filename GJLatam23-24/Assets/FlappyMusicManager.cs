using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMusicManager : MonoBehaviour
{
    //instance para hacer este game obj como DontDestroyOnLoad
    public static FlappyMusicManager Instance;
    public FMODUnity.StudioEventEmitter studioEventEmitter;
    public int IsNewHighScore = 0;
    public int ActiveScene = 0;
    public int IsPaused = 0;

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

    private void Start()
    {
        // MusicScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MusicOnPause(int pause)
    {
        studioEventEmitter.SetParameter("Paused game", pause);
    }

    public void MusicScene(int sceneIndex)
    {
        Debug.Log("Music Scene Index: " + sceneIndex);
        studioEventEmitter.SetParameter("Active Scene", sceneIndex);
    }

    public void NewHighScoreMusic(int newHighScore)
    {
        studioEventEmitter.SetParameter("Is New High Score", newHighScore);
    }
}
