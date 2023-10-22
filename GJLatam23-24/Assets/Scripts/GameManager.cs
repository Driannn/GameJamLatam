using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] int firstScence = 0;
    [SerializeField] int lastScence = 1;
    public bool gameOver = false;

    [SerializeField] private GameObject _gameOverCanvas;

    //FMOD
    FMOD.Studio.EventInstance restetSound;
    [SerializeField] string resetStringEvent = "event:/SFX/restart scene";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1.0f;

    }

    // Update is called once per frame
    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        gameOver = true;
        Debug.Log("Game Over: " + gameOver);
        Time.timeScale = 0f;
    }

    public void ResetGame()
    {
        //play fmod event
        restetSound = FMODUnity.RuntimeManager.CreateInstance(resetStringEvent);
        restetSound.start();
        //reset game to current scene, change it later
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         
        int index = Random.Range(firstScence, lastScence + 1);
        Debug.Log("Load scene: " + index);
        SceneManager.LoadScene(index);

        FlappyMusicManager.Instance.MusicScene(index);
    }
}
