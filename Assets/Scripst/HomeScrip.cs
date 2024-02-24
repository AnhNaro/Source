using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class HomeScrip : MonoBehaviour
{
    public Image home;
    public Button ChoisePicture;
   
    int tt=2;
    private void Awake()
    {
        ChoisePicture.onClick.AddListener(ChanPicture);
        tt = pictureon;
    }
    private void ChanPicture()
    {
        tt++;
        home.sprite = null;
    }

    void Start()
    {
        home = GetComponent<Image>();
    }
    void Update()//thay picture
    {
        if (tt >= 16)
        {
            tt = 1;
        }
         var a =Resources.Load("pic"+tt);
         home.material = (Material)a;
        pictureon = tt;
        
    }
    int pictureon
    {
        get => PlayerPrefs.GetInt("Pic", tt);
        set => PlayerPrefs.SetInt("Pic", value);
    }
}
