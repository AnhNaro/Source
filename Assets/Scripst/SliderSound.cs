using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class SliderSound : MonoBehaviour
{
    public Slider sli;
    public AudioSource audio;
     int tm=11;
    private void Awake()
    {
      
        audio.volume = Music;
        sli.value = audio.volume;
        sli.onValueChanged.AddListener(mutmusic);
    }
    public void ChanMusic()
    {
        tm++;
        if (tm == 12) tm = 1;
        Musicchanger = tm;
        var b = Resources.Load("Sound" + Musicchanger);
        audio.clip = (AudioClip)b;
        audio.Play();
    }
    public void mutmusic(float mu)
    {
        Music = mu;
        audio.volume = mu;
    }
    void Start()
    {
        var b = Resources.Load("Sound" + Musicchanger);
        audio.clip = (AudioClip)b;
        audio.Play();
    }
    float Music
    {
        get => PlayerPrefs.GetFloat("Mu", 1);
        set => PlayerPrefs.SetFloat("Mu", value);
    }
    int Musicchanger
    {
        get => PlayerPrefs.GetInt("ChanMusicNew",11);
        set => PlayerPrefs.SetInt("ChanMusicNew", value);
    }
}
