using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] int firstScence = 0;
    [SerializeField] int lastScence = 1;

    [SerializeField] private GameObject _gameOverCanvas;

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
        
        Time.timeScale = 0f;
    }

    public void ResetGame()
    {
        //reset game to current scene, change it later
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
        int index = Random.Range(firstScence, lastScence + 1);
        Debug.Log(index);
        SceneManager.LoadScene(index);   
    }
}
