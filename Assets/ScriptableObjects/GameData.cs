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

    [Header("Colors")]
    public Color happyColor;
    public Color sadColor;
    public Color vibingColor;

    [Header("Player Input Values")]
    public string chosenMood;
    public Color chosenMoodColor;
}
