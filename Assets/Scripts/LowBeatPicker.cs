using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using UnityEngine.UI;

public class LowBeatPicker : MonoBehaviour
{
    public GameData playerGameData;
    private AudioSource beatAudio;

    public void PlayFirstBeat()
    {
        beatAudio.Stop();

        if (playerGameData.chosenMood == "happy")
        {
            beatAudio.clip = playerGameData.happyLow1;
            playerGameData.chosenLowBeat = playerGameData.happyLow1;
        }
        if (playerGameData.chosenMood == "sad")
        {
            beatAudio.clip = playerGameData.sadLow1;
            playerGameData.chosenLowBeat = playerGameData.sadLow1;
        }
        if (playerGameData.chosenMood == "vibing")
        {
            beatAudio.clip = playerGameData.vibeLow1;
            playerGameData.chosenLowBeat = playerGameData.vibeLow1;
        }
        playerGameData.currentBeat = "beat1";
        beatAudio.Play();
    }
    public void PlaySecondBeat()
    {
        beatAudio.Stop();
        if (playerGameData.chosenMood == "happy")
        {
            beatAudio.clip = playerGameData.happyLow2;
            playerGameData.chosenLowBeat = playerGameData.happyLow2;
        }
        if (playerGameData.chosenMood == "sad")
        {
            beatAudio.clip = playerGameData.sadLow2;
            playerGameData.chosenLowBeat = playerGameData.sadLow2;
        }
        if (playerGameData.chosenMood == "vibing")
        {
            beatAudio.clip = playerGameData.vibeLow2;
            playerGameData.chosenLowBeat = playerGameData.vibeLow2;
        }

        playerGameData.currentBeat = "beat2";
        beatAudio.Play();
    }
    public void PlayThirdBeat()
    {
        beatAudio.Stop();
        if (playerGameData.chosenMood == "happy")
        {
            beatAudio.clip = playerGameData.happyLow3;
            playerGameData.chosenLowBeat = playerGameData.happyLow3;
        }
        if (playerGameData.chosenMood == "sad")
        {
            beatAudio.clip = playerGameData.sadLow3;
            playerGameData.chosenLowBeat = playerGameData.sadLow3;
        }
        if (playerGameData.chosenMood == "vibing")
        {
            beatAudio.clip = playerGameData.vibeLow3;
            playerGameData.chosenLowBeat = playerGameData.vibeLow3;
        }

        playerGameData.currentBeat = "beat3";
        beatAudio.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        beatAudio = GetComponent<AudioSource>();
    }
}
