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

    public ParticleSystem beat1ParticleSystem;
    public ParticleSystem beat2ParticleSystem;
    public ParticleSystem beat3ParticleSystem;

    public GameData playerGameData;

    private Color randomShade;

    // Start is called before the first frame update
    void Start()
    {
        float H, S, V;
        ParticleSystem.MainModule beat1ParticleModule = beat1ParticleSystem.main;
        ParticleSystem.MainModule beat2ParticleModule = beat2ParticleSystem.main;
        ParticleSystem.MainModule beat3ParticleModule = beat3ParticleSystem.main;

        ColorBlock chosenColorBlock = new ColorBlock();
        Color normalHSV, disabledHSV, selectedHSV, highlightedHSV, pressedHSV, beat1HSV, beat2HSV, beat3HSV, backgroundHSV, titleHSV, subtitleHSV;
        Color beat1VizHSV, beat2VizHSV, beat3VizHSV;
        Color beat1RestHSV, beat2RestHSV, beat3RestHSV;
        Color beat1ParticleHSV, beat2ParticleHSV, beat3ParticleHSV;
        Color.RGBToHSV(playerGameData.chosenMoodColor, out H, out S, out V);

        backgroundHSV = Color.HSVToRGB((float)(H + 0.01), S, V);
        titleHSV = Color.HSVToRGB((float)(H + 0.02), S, V);
        subtitleHSV = Color.HSVToRGB((float)(H + 0.03), S, V);

        normalHSV = Color.HSVToRGB((float)(H + 0.04), S, V);
        disabledHSV = Color.HSVToRGB((float)(H + 0.05), S, V);
        selectedHSV = Color.HSVToRGB((float)(H + 0.06), S, V);
        highlightedHSV = Color.HSVToRGB((float)(H + 0.07), S, V);
        pressedHSV = Color.HSVToRGB((float)(H + 0.08), S, V);

        beat1HSV = Color.HSVToRGB((float)(H + 0.09), S, V);
        beat2HSV = Color.HSVToRGB((float)(H + 0.1), S, V);
        beat3HSV = Color.HSVToRGB((float)(H + 0.11), S, V);

        beat1VizHSV = Color.HSVToRGB((float)(H + 0.12), S, V);
        beat2VizHSV = Color.HSVToRGB((float)(H + 0.13), S, V);
        beat3VizHSV = Color.HSVToRGB((float)(H + 0.14), S, V);

        beat1RestHSV = Color.HSVToRGB((float)(H + 0.15), S, V);
        beat2RestHSV = Color.HSVToRGB((float)(H + 0.16), S, V);
        beat3RestHSV = Color.HSVToRGB((float)(H + 0.17), S, V);

        beat1ParticleHSV = Color.HSVToRGB((float)(H + 0.2), S, V);
        beat2ParticleHSV = Color.HSVToRGB((float)(H + 0.3), S, V);
        beat3ParticleHSV = Color.HSVToRGB((float)(H + 0.4), S, V);


        chosenColorBlock.normalColor = normalHSV;
        chosenColorBlock.disabledColor = disabledHSV;
        chosenColorBlock.selectedColor = selectedHSV;
        chosenColorBlock.highlightedColor = highlightedHSV;
        chosenColorBlock.pressedColor = pressedHSV;

        Color[] beatColors = new Color[] { beat1HSV, beat2HSV, beat3HSV };

        colorBackground.color = backgroundHSV;
        title.color = titleHSV;
        subtitle.color = subtitleHSV;

        beat1Viz.color = beat1VizHSV;
        beat1Viz.GetComponent<AudioSyncColor>().restColor = beat1RestHSV;
        beat1Viz.GetComponent<AudioSyncColor>().beatColors = beatColors;
        beat2Viz.color = beat2VizHSV;
        beat2Viz.GetComponent<AudioSyncColor>().restColor = beat2RestHSV;
        beat2Viz.GetComponent<AudioSyncColor>().beatColors = beatColors;
        beat3Viz.color = beat3VizHSV;
        beat3Viz.GetComponent<AudioSyncColor>().restColor = beat3RestHSV;
        beat3Viz.GetComponent<AudioSyncColor>().beatColors = beatColors;

        beat1Button.GetComponent<Image>().color = normalHSV;
        beat1Button.GetComponent<Button>().colors = chosenColorBlock;

        beat2Button.GetComponent<Image>().color = normalHSV;
        beat2Button.GetComponent<Button>().colors = chosenColorBlock;

        beat3Button.GetComponent<Image>().color = normalHSV;
        beat3Button.GetComponent<Button>().colors = chosenColorBlock;

        beat1ParticleModule.startColor = beat1ParticleHSV;
        beat2ParticleModule.startColor = beat2ParticleHSV;
        beat3ParticleModule.startColor = beat3ParticleHSV;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
