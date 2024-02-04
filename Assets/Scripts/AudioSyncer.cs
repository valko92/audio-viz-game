using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioSyncer : MonoBehaviour
{
    // what spectrum val triggers a beat
    public float bias;
    // min interval between beats
    public float timeStep;
    // how much time before viz completes
    public float timeToBeat;
    // how fast obj rests after a beat
    public float restSmoothTime;

    private float m_previousAudioValue;
    private float m_audioValue;
    private float m_timer;

    protected bool m_isBeat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }

    public virtual void OnUpdate()
    {
        m_previousAudioValue = m_audioValue;
        m_audioValue = AudioSpectrum.spectrumValue;

        if (m_previousAudioValue > bias && m_audioValue <= bias)
        {
            if (m_timer > timeStep)
            {
                OnBeat();
            }
        }

        if (m_previousAudioValue <= bias && m_audioValue > bias) { 
            if (m_timer > timeStep)
            {
                OnBeat();
            }
        }

        m_timer += Time.deltaTime;
    }

    public virtual void OnBeat()
    {
        Debug.Log("beat");
        m_timer = 0;
        m_isBeat = true;
    }
}
