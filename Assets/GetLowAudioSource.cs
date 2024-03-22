using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLowAudioSource : MonoBehaviour
{
    public GameData playerGameData;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        if (playerGameData.chosenLowBeat)
        {
            audioSource.clip = playerGameData.chosenLowBeat;
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
