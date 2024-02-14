using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    public Image colorBackground;
    public TextMeshProUGUI title;
    public TextMeshProUGUI subtitle;

    public Image beat1Viz;
    public Image beat2Viz;
    public Image beat3Viz;

    public Button beat1Button;
    public Button beat2Button;
    public Button beat3Button;

    public GameData playerGameData;

    private Color randomShade;

    // Start is called before the first frame update
    void Start()
    {
        ColorBlock chosenColorBlock = new ColorBlock();
        chosenColorBlock.normalColor = playerGameData.chosenMoodColor;
        chosenColorBlock.disabledColor = playerGameData.chosenMoodColor;
        chosenColorBlock.selectedColor = playerGameData.chosenMoodColor;
        chosenColorBlock.highlightedColor = playerGameData.chosenMoodColor;
        chosenColorBlock.pressedColor = playerGameData.chosenMoodColor;

        Color[] beatColors = new Color[] {playerGameData.chosenMoodColor, playerGameData.chosenMoodColor, playerGameData.chosenMoodColor };

        colorBackground.color = playerGameData.chosenMoodColor;
        title.color = playerGameData.chosenMoodColor;
        subtitle.color = playerGameData.chosenMoodColor;

        beat1Viz.color = playerGameData.chosenMoodColor;
        beat1Viz.GetComponent<AudioSyncColor>().restColor = playerGameData.chosenMoodColor;
        beat1Viz.GetComponent<AudioSyncColor>().beatColors = beatColors;
        beat2Viz.color = playerGameData.chosenMoodColor;
        beat2Viz.GetComponent<AudioSyncColor>().restColor = playerGameData.chosenMoodColor;
        beat2Viz.GetComponent<AudioSyncColor>().beatColors = beatColors;
        beat3Viz.color = playerGameData.chosenMoodColor;
        beat3Viz.GetComponent<AudioSyncColor>().restColor = playerGameData.chosenMoodColor;
        beat3Viz.GetComponent<AudioSyncColor>().beatColors = beatColors;

        beat1Button.GetComponent<Image>().color = playerGameData.chosenMoodColor;
        beat1Button.GetComponent<Button>().colors = chosenColorBlock;

        beat2Button.GetComponent<Image>().color = playerGameData.chosenMoodColor;
        beat2Button.GetComponent<Button>().colors = chosenColorBlock;

        beat3Button.GetComponent<Image>().color = playerGameData.chosenMoodColor;
        beat3Button.GetComponent<Button>().colors = chosenColorBlock;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
