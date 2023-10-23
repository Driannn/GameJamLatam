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
    public int ScoreNumber = 0;
    public int DeathNumber = 0;
    public int HighScore = 0;

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
        Debug.Log("Music on pause: " + pause);
        studioEventEmitter.SetParameter("Paused game", pause);
    }

    public void MusicScene(int sceneIndex)
    {
        Debug.Log("Music Scene Index: " + sceneIndex);
        studioEventEmitter.SetParameter("Active Scene", sceneIndex);
    }

    public void NewHighScoreMusic(int newHighScore)
    {
        Debug.Log("New High Score Music: " + newHighScore);
        studioEventEmitter.SetParameter("New High Score", newHighScore);
    }

    public void MusicScore(int score)
    {
        Debug.Log("Music Score: " + score);
        studioEventEmitter.SetParameter("Score Number", score);
    }

    public void MusicDeath(int death)
    {
        Debug.Log("Music DeathCount: " + death);
        studioEventEmitter.SetParameter("Death Number", death);
    }

    public void CheckHighScore(int score)
    {
        studioEventEmitter.SetParameter("High Score", score);
    }
}
