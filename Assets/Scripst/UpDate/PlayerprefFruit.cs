using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerprefFruit : MonoBehaviour
{
    public static PlayerprefFruit instanFruit;
    public Text txtanimFruit;
    [Header("ShopSell")]
    [Header(" ")]
    [SerializeField] Text txtCam;
    [SerializeField] Text txtChuoi;
    [SerializeField] Text txtLe;
    [SerializeField] Text txtTao;
    [SerializeField] Text txtDau;
    [SerializeField] Text txtBo;
    [SerializeField] Text txtNho;
    [SerializeField] Text txtDuiga;
    [SerializeField] Text txtBapcai;
    [SerializeField] Text txtCucai;
    [SerializeField] Text txtCarot;
    [SerializeField] Text txtCachua;
    [Header("ShopBy")]
    [Header(" ")]
    [SerializeField] Text Bycam;
    [SerializeField] Text ByDau;
    [SerializeField] Text ByTao;
    [SerializeField] Text ByBo;
    [Header("PlayGame")]
    [Header(" ")]
    [SerializeField] Text GameTao;
    [SerializeField] Text GameBo;
    [SerializeField] Text GameDau;
    [SerializeField] Text GameCam;
    private void Awake()
    {
        instanFruit = this;
        txtCam.text = Cam.ToString();
        txtChuoi.text = Chuoi.ToString();
        txtLe.text = Le.ToString();
        txtTao.text = Tao.ToString();   
        txtDau.text = Dau.ToString();
        txtBo.text = Bo.ToString();
        txtBo.text=Bo.ToString();
        txtNho.text = Nho.ToString();
        txtDuiga.text= Duiga.ToString();
        txtBapcai.text= Bapcai.ToString();  
        txtCucai.text= Cucai.ToString();    
        txtCarot.text= Carot.ToString();    
        txtCachua.text= Cachua.ToString();
    }
    private void Update()
    {
        txtCam.text = Cam.ToString();
        txtChuoi.text = Chuoi.ToString();
        txtLe.text = Le.ToString();
        txtTao.text = Tao.ToString();
        txtDau.text = Dau.ToString();
        txtBo.text = Bo.ToString();
        txtBo.text = Bo.ToString();
        txtNho.text = Nho.ToString();
        txtDuiga.text = Duiga.ToString();
        txtBapcai.text = Bapcai.ToString();
        txtCucai.text = Cucai.ToString();
        txtCarot.text = Carot.ToString();
        txtCachua.text = Cachua.ToString();
        //By
        Bycam.text = Cam.ToString();    
        ByBo.text = Bo.ToString();
        ByDau.text = Dau.ToString();    
        ByTao.text = Tao.ToString();
        //Gameplay
        GameBo.text=Bo.ToString();
        GameCam.text=Cam.ToString();
        GameDau.text=Dau.ToString();
        GameTao.text=Tao.ToString();
      
    }
    public int Cam
    {
        get => PlayerPrefs.GetInt("cam", 2);
        set => PlayerPrefs.SetInt("cam", value);
    }
    public int Chuoi
    {
        get => PlayerPrefs.GetInt("chuoi", 2);
        set => PlayerPrefs.SetInt("chuoi", value);
    }
    public int Le
    {
        get => PlayerPrefs.GetInt("le", 2);
        set => PlayerPrefs.SetInt("le", value);
    }
    public int Tao
    {
        get => PlayerPrefs.GetInt("tao", 2);
        set => PlayerPrefs.SetInt("tao", value);
    }
    public int Dau
    {
        get => PlayerPrefs.GetInt("dau", 2);
        set => PlayerPrefs.SetInt("dau", value);
    }
    public int Bo
    {
        get => PlayerPrefs.GetInt("bo", 2);
        set => PlayerPrefs.SetInt("bo", value);
    }
    public int Nho
    {
        get => PlayerPrefs.GetInt("nho",2);
        set => PlayerPrefs.SetInt("nho", value);
    }
    public int Duiga
    {
        get => PlayerPrefs.GetInt("duiga", 2);
        set => PlayerPrefs.SetInt("duiga", value);
    }
    public int Bapcai
    {
        get => PlayerPrefs.GetInt("bapcai", 2);
        set => PlayerPrefs.SetInt("bapcai", value);
    }
    public int Carot
    {
        get => PlayerPrefs.GetInt("carot", 2);
        set => PlayerPrefs.SetInt("carot", value);
    }
    public int Cucai
    {
        get => PlayerPrefs.GetInt("cucai", 2);
        set => PlayerPrefs.SetInt("cucai", value);
    }
    public int Cachua
    {
        get => PlayerPrefs.GetInt("cachua", 2);
        set => PlayerPrefs.SetInt("cachua", value);
    }
    // Add fruit
    public void AddCam()
    {
        Cam++;
    }
    public void AddChuoi()
    {
        Chuoi++;
    }
    public void AddTao()
    {
        Tao++;
    }
    public void AddNho()
    {
        Nho++;
    }
    public void AddDau()
    {
        Dau++;
    }
    public void AddBo()
    {
        Bo++;
    }
    public void AddDuiGa()
    {
        Duiga++;
    }
    public void AddBapCai()
    {
        Bapcai++;
    }
    public void AddCuCai()
    {
        Cucai++;
    }
    public void AddCaChua()
    {
        Cachua++;
    }
    public void AddLe()
    {
        Le++;
    }
    public void AddCaRot()
    {
        Carot++;
    }
    // Lessfruit,+Gold

    public void LessCam()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Cam >= 1)
        {
            Cam--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Cam < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessChuoi()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Chuoi >= 1)
        {
            Chuoi--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Chuoi < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessTao()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Tao >= 1)
        {
            Tao--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Tao < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessNho()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Nho >= 1)
        {
            Nho--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Nho < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessDau()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Dau >= 1)
        {
            Dau--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Dau < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessBo()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Bo >= 1)
        {
            Bo--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Bo < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessDuiGa()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Duiga >= 1)
        {
            Duiga--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Duiga < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessBapCai()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Bapcai >= 1)
        {
            Bapcai--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Bapcai < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessCuCai()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Cucai >= 1)
        {
            Cucai--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Cucai < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessCaChua()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Cachua >= 1)
        {
            Cachua--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Cachua < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessLe()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Le >= 1)
        {
            Le--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Le < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    public void LessCaRot()
    {
        txtanimFruit.gameObject.SetActive(false);
        if (Carot >= 1)
        {
            Carot--;
            Player.ChangerMessenger.characterData.TangCoin();
        }
        if (Carot < 1)
        {
            txtanimFruit.gameObject.SetActive(true);
        }
    }
    // Gamplaybuttonfruit
    public void userbuttonCam()
    {
        Cam--;
    }
    public void userbuttonDau()
    {
        Dau--;
    }
    public void userbuttonTao()
    {
        Tao--;
    }
    public void userbuttonBo()
    {
        Bo--;
    }
}
