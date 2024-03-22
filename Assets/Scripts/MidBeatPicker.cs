using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using UnityEngine.UI;

public class MidBeatPicker : MonoBehaviour
{
    public GameData playerGameData;
    public AudioSource lowBGSource;
    private AudioSource beatAudio;

    public void PlayFirstBeat()
    {
        beatAudio.Stop();

        if (playerGameData.chosenMood == "happy")
        {
            beatAudio.clip = playerGameData.happyMid1;
            playerGameData.chosenMidBeat = playerGameData.happyMid1;
        }
        if (playerGameData.chosenMood == "sad")
        {
            beatAudio.clip = playerGameData.sadMid1;
            playerGameData.chosenMidBeat = playerGameData.sadMid1;
        }
        if (playerGameData.chosenMood == "vibing")
        {
            beatAudio.clip = playerGameData.vibeMid1;
            playerGameData.chosenMidBeat = playerGameData.vibeMid1;
        }
        playerGameData.currentBeat = "beat1";
        lowBGSource.Play();
        beatAudio.Play();
    }
    public void PlaySecondBeat()
    {
        beatAudio.Stop();
        if (playerGameData.chosenMood == "happy")
        {
            beatAudio.clip = playerGameData.happyMid2;
            playerGameData.chosenMidBeat = playerGameData.happyMid2;
        }
        if (playerGameData.chosenMood == "sad")
        {
            beatAudio.clip = playerGameData.sadMid2;
            playerGameData.chosenMidBeat = playerGameData.sadMid2;
        }
        if (playerGameData.chosenMood == "vibing")
        {
            beatAudio.clip = playerGameData.vibeMid2;
            playerGameData.chosenMidBeat = playerGameData.vibeMid2;
        }

        playerGameData.currentBeat = "beat2";
        lowBGSource.Play();
        beatAudio.Play();
    }
    public void PlayThirdBeat()
    {
        beatAudio.Stop();
        if (playerGameData.chosenMood == "happy")
        {
            beatAudio.clip = playerGameData.happyMid3;
            playerGameData.chosenMidBeat = playerGameData.happyMid3;
        }
        if (playerGameData.chosenMood == "sad")
        {
            beatAudio.clip = playerGameData.sadMid3;
            playerGameData.chosenMidBeat = playerGameData.sadMid3;
        }
        if (playerGameData.chosenMood == "vibing")
        {
            beatAudio.clip = playerGameData.vibeMid3;
            playerGameData.chosenMidBeat = playerGameData.vibeMid3;
        }

        playerGameData.currentBeat = "beat3";
        lowBGSource.Play();
        beatAudio.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        beatAudio = GetComponent<AudioSource>();
    }
}
