using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HUD : MonoBehaviour
{
    public static HUD instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;
    [SerializeField] private TextMeshProUGUI _deathCountText;

    private int _score;
    private int _deaths = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //this part was made by Copilot within the Edge browser

    public static class GlobalControl
    {
        public static int DeathCount = 0;
    }

    void Start()
    {
        _score = 0;
        _currentScoreText.text = _score.ToString();

        _deaths = GlobalControl.DeathCount;
        _deathCountText.text = _deaths.ToString();

        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            FlappyMusicManager.Instance.NewHighScoreMusic(1);
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }

    public void UpdateDeaths()
    {
        _deaths++;
        GlobalControl.DeathCount = _deaths;
        _deathCountText.text = _deaths.ToString();
    }



    /*   // Start is called before the first frame update
       void Start()
       {
           _currentScoreText.text = _score.ToString();
           _deathCountText.text = _deaths.ToString();

           _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
           _deathCountText.text = PlayerPrefs.GetInt("DeathCount", 0).ToString();

           UpdateHighScore();
       }

       private void UpdateHighScore()
       {
           if (_score > PlayerPrefs.GetInt("HighScore"))
           {
               PlayerPrefs.SetInt("HighScore", _score);
               _highScoreText.text = _score.ToString();
           }
       }

       public void UpdateScore()
       {
           _score++;
           _currentScoreText.text = _score.ToString();
           UpdateHighScore();
       }

       public void UpdateDeaths()
       {
           _deaths++;
           _deathCountText.text= _deaths.ToString();

           PlayerPrefs.SetInt("DeathCount", _deaths);
           _deathCountText.text = _deaths.ToString();
       }
   */
}
