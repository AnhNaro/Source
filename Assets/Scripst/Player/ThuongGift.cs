using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThuongGift : MonoBehaviour
{ 
    [SerializeField] Button GiftTao;
    [SerializeField] Button GiftDau;
    [SerializeField] Button GiftBo;
    [SerializeField] Button GiftCam;

    DateTime ngaythuong = DateTime.Now;
    DateTime ngaymoi = DateTime.Now;

    [SerializeField] Button imagebuttonCam;
    [SerializeField] Button imagebuttonDau;
    [SerializeField] Button imagebuttonTao;
    [SerializeField] Button imagebuttonBo;
    private void Awake()
    {
        GiftBo.onClick.AddListener(() =>
        {
            GiftBo.interactable = false;
            Fruitib = 1;
        });
        GiftTao.onClick.AddListener(() =>
        {
            GiftTao.interactable = false;
            Fruitit = 1;
        });
        GiftDau.onClick.AddListener(() =>
        {
            GiftDau.interactable = false;
            Fruitid = 1;
        });
        GiftCam.onClick.AddListener(() =>
        {
            GiftCam.interactable = false;
            Fruitic = 1;
        });
    }
    void Update()
    {
        Ngayh = ngaymoi.DayOfYear+1;
        if (Fruitic == 1)//cam
        {
            GiftCam.interactable = false;
        }
        else
        {
            GiftCam.interactable=true;
        }
        if (Fruitid == 1)//dau
        {
            GiftDau.interactable = false;
        }
        else
        {
            GiftDau.interactable = true;
        }
        if (Fruitit == 1)//tao
        {
            GiftTao.interactable = false;
        }
        else 
        {
            GiftTao.interactable = true;
        }
        if (Fruitib == 1)//bo
        {
            GiftBo.interactable = false;
        }
        else 
        {
            GiftBo.interactable = true;
        }


        //fruit tuong tacgame
        if (PlayerprefFruit.instanFruit.Cam <= 0)
        {
            imagebuttonCam.interactable = false;
            Manager.Instance.SoundCauBang.enabled=false;
        }
        else
        {
            imagebuttonCam.interactable = true;
            Manager.Instance.SoundCauBang.enabled = true;
        }

        if (PlayerprefFruit.instanFruit.Dau <= 0)
        {
            imagebuttonDau.interactable = false;
            Manager.Instance.SoundHp.enabled = false;
        }
        else
        {
            imagebuttonDau.interactable = true;
            Manager.Instance.SoundHp.enabled = true;
        }

        if (PlayerprefFruit.instanFruit.Bo <= 0)
        {
            imagebuttonBo.interactable = false;
            Manager.Instance.SoundThuatthuc.enabled = false;
        }
        else
        {
            imagebuttonBo.interactable = true;
            Manager.Instance.SoundThuatthuc.enabled = true;
        }

        if (PlayerprefFruit.instanFruit.Tao <= 0)
        {
            imagebuttonTao.interactable = false;
            Manager.Instance.SoundBom.enabled = false;
        }
        else
        {
            imagebuttonTao.interactable = true;
            Manager.Instance.SoundBom.enabled = true;
        }
    }
    public void Thuong()
    {
        Fruitic = 0;
        Fruitib = 0;
        Fruitid = 0;
        Fruitit = 0;
    }
    public int Ngayh
    {
        get => PlayerPrefs.GetInt("ngayh",ngaythuong.DayOfYear);
        set
        {
            if (value > PlayerPrefs.GetInt("ngayh",ngaythuong.DayOfYear))
            {
                PlayerPrefs.SetInt("ngayh", value);
                Thuong();
            }
        }
    }
    int Fruitic
    {
        get => PlayerPrefs.GetInt("btncam", 0);
        set => PlayerPrefs.SetInt("btncam", value);
    }
    int Fruitit
    {
        get => PlayerPrefs.GetInt("btnTao", 0);
        set => PlayerPrefs.SetInt("btnTao", value);
    }
    int Fruitid
    {
        get => PlayerPrefs.GetInt("btndau", 0);
        set => PlayerPrefs.SetInt("btndau", value);
    }
    int Fruitib
    {
        get => PlayerPrefs.GetInt("btnbo", 0);
        set => PlayerPrefs.SetInt("btnbo", value);
    }
   
}
