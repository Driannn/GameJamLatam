using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{/*
    //instance para hacer este game obj como DontDestroyOnLoad
    public static MusicManager Instance;
    public FMODUnity.StudioEventEmitter studioEventEmitter;
    public int musicState;

    //public GameObject raceController = null;
    public RaceController raceComponent;

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

    // Update is called once per frame
    //void Update()
    //{
    //    Debug.Log("Update MusicManager");

    //    int menu = CheckActiveState();
    //    var emitter = GetComponent<FMODUnity.StudioEventEmitter>(); //referencia un componente de FMOD q esta en este mismo gameobject y emitira el audio
    //    emitter.SetParameter("State", menu); //cambia el parametro del emiter fmod segun la velocidad del carro para q el sonido del motor sea distinto dependiendo de la velocidad del carro 


    //}

    public void MusicToEmitt(int menu)
    {
        musicState = menu;
        studioEventEmitter.SetParameter("State", menu);
    }

    public void MusicOnPause(int pause)
    {
        studioEventEmitter.SetParameter("Pause", pause);
    }
    int CheckActiveState()
    {
        //Debug.Log("CheckState");

        //if (mainMenu != null)
        //{

        //    if (mainMenu.activeInHierarchy || optionMenu.activeInHierarchy)
        //    {
        //        Debug.Log("Music State 0, menu 1");
        //        return 0;
        //    }
        //    else if (gameModeMenu.activeInHierarchy)
        //    {
        //        Debug.Log("Music State 1, menu 2");
        //        return 1;
        //    }
        //    else if (selectCarMenu.activeInHierarchy || selectTrackMenu.activeInHierarchy)
        //    {
        //        Debug.Log("Music State 2, menu 3");
        //        return 2;
        //    }
           
        //    return 3;

        //}

        raceComponent = GameObject.Find("RaceController").GetComponent<RaceController>();

        if (raceComponent.WinRace == true || raceComponent.LoseRace == true)
        {
            Debug.Log("Music State 5, EndRace");
            return 5;
        }

        if (raceComponent.LastLap == true)
        {
            Debug.Log("Music State 4, LastLap");
            return 4;
        }

        Debug.Log("Music State 3 On Race");
        return 3;

    }
    */
}
