using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;
    public static AudioManager Instance
    {
        get
        {
            if (_instance == null) Debug.Log("AudioManager:_instance:NULL");
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
    [SerializeField] private AudioSource _BGM;
    [SerializeField] private AudioClip _LetterBGM;
    [SerializeField] private AudioClip _MainBGM;
    void Start()
    {
        Play(_MainBGM);
    }
    public void Play(AudioClip audio)
    {
        _BGM.clip = audio;
        _BGM.PlayDelayed(0.5f);
    }
    public void PauseBGM()
    {
        _BGM.Pause();
    }
    public void UnPauseBGM()
    {
        _BGM.UnPause();
    }    
}