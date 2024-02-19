using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using UnityEngine.UI;

public class MoodPicker : MonoBehaviour
{
    public GameData playerGameData; 
    private AudioSource moodAudio;

    public void PlayHappyTune()
    {
        moodAudio.Stop();
        moodAudio.clip = playerGameData.happyClip;
        moodAudio.Play();

        playerGameData.chosenMood = "happy";
        playerGameData.chosenMoodColor = playerGameData.happyColor;
        playerGameData.currentBeat = "beat1";
    }
    public void PlaySadTune()
    {
        moodAudio.Stop();
        moodAudio.clip = playerGameData.sadClip;
        moodAudio.Play();

        playerGameData.chosenMood = "sad";
        playerGameData.chosenMoodColor = playerGameData.sadColor;
        playerGameData.currentBeat = "beat2";
    }
    public void PlayVibingTune()
    {
        moodAudio.Stop();
        moodAudio.clip = playerGameData.vibingClip;
        moodAudio.Play();

        playerGameData.chosenMood = "vibing";
        playerGameData.chosenMoodColor = playerGameData.vibingColor;
        playerGameData.currentBeat = "beat3";
    }
    // Start is called before the first frame update
    void Start()
    {
        moodAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
