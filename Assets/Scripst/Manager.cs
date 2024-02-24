using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject WinScene;
    public GameObject LossScene;
    public static Manager Instance;
    public Button[] button;
    public AudioSource Audio;
    public AudioSource AudioWin;
    public AudioSource AudioLoss;
    [Header(" ")]
    public AudioSource SoundAttackplayer;
    public AudioSource SoundCauBang;
    public AudioSource SoundBangpha;
    public AudioSource SoundThuatthuc;
    public AudioSource SoundBom;
    public AudioSource SoundHp;
    public AudioSource SoundKiemThan;
    public AudioSource SoundCuaphat;
    public AudioSource SoundJump;
    public AudioSource SoundQP;
    public AudioSource SoundItem;
    public int LockLevel
    {
        get => PlayerPrefs.GetInt("unlock",1);
        set => PlayerPrefs.SetInt("unlock", value);
    }
    int Unlock;
    private void Awake()
    {
     Instance=this;
        Unlock = LockLevel;
        for(int i = 0;i< button.Length; i++)
        {
            button[i].interactable = false;
        }
        for(int i = 0; i < Unlock; i++)
        {
            button[i].interactable = true;
        }
     
    }
    private void FixedUpdate()
    {
        Unlock = LockLevel;
        for (int i = 0; i < Unlock; i++)
        {
            button[i].interactable = true;  
        }
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
        Time.timeScale = 1.0f;
    }
    
    public void WinComplete()
    {
        WinScene.gameObject.SetActive(true);
        Player.ChangerMessenger.characterData.PlayerLevelCoin += 50;
        AudioWin.Play();
        Audio.Stop();
        Time.timeScale = 0;
    }
    public void Loss()
    {
        LossScene.gameObject.SetActive(true);
        AudioLoss.Play();
        Audio.Stop();   
        Time.timeScale = 0;
    }
    public void Pause()
    {
        Time.timeScale = 0;
        Audio.Pause();
    }
    public void ReSume()
    {
        Time.timeScale = 1;
        Audio.Play();
    }
}
