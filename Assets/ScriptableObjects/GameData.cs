using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    [Header("Audio Clips")]
    public AudioClip happyClip;
    public AudioClip sadClip;
    public AudioClip vibingClip;

    [Header("Happy Low Beats")]
    public AudioClip happyLow1;
    public AudioClip happyLow2;
    public AudioClip happyLow3;

    [Header("Happy Mid Beats")]
    public AudioClip happyMid1;
    public AudioClip happyMid2;
    public AudioClip happyMid3;

    [Header("Happy High Beats")]
    public AudioClip happyHigh1;
    public AudioClip happyHigh2;
    public AudioClip happyHigh3;

    [Header("Sad Low Beats")]
    public AudioClip sadLow1;
    public AudioClip sadLow2;
    public AudioClip sadLow3;

    [Header("Sad Mid Beats")]
    public AudioClip sadMid1;
    public AudioClip sadMid2;
    public AudioClip sadMid3;

    [Header("Sad High Beats")]
    public AudioClip sadHigh1;
    public AudioClip sadHigh2;
    public AudioClip sadHigh3;

    [Header("Vibe Low Beats")]
    public AudioClip vibeLow1;
    public AudioClip vibeLow2;
    public AudioClip vibeLow3;

    [Header("Vibe Mid Beats")]
    public AudioClip vibeMid1;
    public AudioClip vibeMid2;
    public AudioClip vibeMid3;

    [Header("Vibe High Beats")]
    public AudioClip vibeHigh1;
    public AudioClip vibeHigh2;
    public AudioClip vibeHigh3;

    [Header("Colors")]
    public Color happyColor;
    public Color sadColor;
    public Color vibingColor;

    [Header("Player Input Values")]
    public string chosenMood;
    public Color chosenMoodColor;
    public AudioClip chosenLowBeat;
    public string currentBeat;
}
