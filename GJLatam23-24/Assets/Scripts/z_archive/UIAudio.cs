using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudio : MonoBehaviour
{
    FMOD.Studio.EventInstance UIsound;

    [SerializeField] string carSelected = "event:/SFX/UI/selection/car selected";
    [SerializeField] string trackSelected = "event:/SFX/UI/selection/race track selected";
    [SerializeField] string selected = "event:/SFX/UI/Navigation/selected";
    [SerializeField] string sideSelection = "event:/SFX/UI/Navigation/sides";
    [SerializeField] string back = "event:/SFX/UI/Navigation/back";
    [SerializeField] string nullAction = "event:/SFX/UI/Navigation/null";

    public void CarSelected()
    {
        UIsound = FMODUnity.RuntimeManager.CreateInstance(carSelected);
        UIsound.start();
    }
    public void TrackSlected()
    {
        UIsound = FMODUnity.RuntimeManager.CreateInstance(trackSelected);
        UIsound.start();
    }
    public void Selected()
    {
        UIsound = FMODUnity.RuntimeManager.CreateInstance(selected);
        UIsound.start();
    }
    public void Back()
    {
        UIsound = FMODUnity.RuntimeManager.CreateInstance(back);
        UIsound.start();
    }
    public void NullAction()
    {
        UIsound = FMODUnity.RuntimeManager.CreateInstance(nullAction);
        UIsound.start();
    }
    public void SideSelection()
    {
        UIsound = FMODUnity.RuntimeManager.CreateInstance(sideSelection);
        UIsound.start();
    }

}
