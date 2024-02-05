using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicColorBackground : MonoBehaviour
{
    public GameData playerGameData;
    private Image currentBackground;
    private Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        currentBackground = GetComponent<Image>();
        newColor = new Color(1f, 1f, 1f, 0f);
        newColor.a = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerGameData.chosenMood != null)
        {
            newColor = playerGameData.chosenMoodColor;
            newColor.a = 0.2f;
            currentBackground.color = newColor;
        }
    }
}
