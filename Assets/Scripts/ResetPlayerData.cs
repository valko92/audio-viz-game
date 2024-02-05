using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerData : MonoBehaviour
{
    public GameData playerGameData;
    // Start is called before the first frame update
    void Start()
    {
        playerGameData.chosenMood = null;
        playerGameData.chosenMoodColor = new Color(1f, 1f, 1f, 0f);
    }
}
