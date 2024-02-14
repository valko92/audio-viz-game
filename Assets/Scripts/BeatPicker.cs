using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using UnityEngine.UI;

public class BeatPicker : MonoBehaviour
{
    public GameData playerGameData;
    public AudioClip beat1clip;
    public AudioClip beat2clip;
    public AudioClip beat3clip;
    private AudioSource beatAudio;

    public void PlayHappyBeat()
    {
        beatAudio.Stop();
        beatAudio.clip = beat1clip;
        beatAudio.Play();

        playerGameData.chosenLowBeat = beat1clip;
    }
    public void PlaySadBeat()
    {
        beatAudio.Stop();
        beatAudio.clip = beat2clip;
        beatAudio.Play();

        playerGameData.chosenLowBeat = beat1clip;
    }
    public void PlayVibingBeat()
    {
        beatAudio.Stop();
        beatAudio.clip = beat3clip;
        beatAudio.Play();

        playerGameData.chosenLowBeat = beat1clip;
    }
    // Start is called before the first frame update
    void Start()
    {
        beatAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
