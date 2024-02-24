using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateAttackplayer : MonoBehaviour
{
    [SerializeField] Text txtanimgold;
    [SerializeField] CharacterData Kiem;
    [SerializeField] CharacterData Khien;
    [SerializeField] CharacterData CauBang;
    [SerializeField] CharacterData CuaPhat;
    [SerializeField] CharacterData Bom;
    [SerializeField] CharacterData BangPha;
    [SerializeField] CharacterData ThuatThuc;
    [SerializeField] CharacterData ThanhKiem;
    [SerializeField] CharacterData HpCharacter;
    [SerializeField] Text AtkKiem;
    [SerializeField] Text AtkKhien;
    [SerializeField] Text AtkCuaPhat;
    [SerializeField] Text AtkCauBang;
    [SerializeField] Text AtkThuatThuc;
    [SerializeField] Text AtkThanhKiem;
    [SerializeField] Text AtkBom;
    [SerializeField] Text AtkBangPha;
    [SerializeField] Text txtHpplayer;
    private void Update()
    {
        AtkKiem.text="ATk: "+Kiem.Atk;
        AtkKhien.text = "Atk: " + Khien.Atk;
        AtkCuaPhat.text = "Atk: " + CuaPhat.Atk;
        AtkCauBang.text = "Atk: " + CauBang.Atk;
        AtkThanhKiem.text = "Atk: " + ThanhKiem.Atk;
        AtkThuatThuc.text = " Atk: " + ThuatThuc.Atk;
        AtkBom.text = "Atk: " + Bom.Atk;
        AtkBangPha.text = "Atk: " + BangPha.Atk;
        txtHpplayer.text="Hp: "+HpCharacter.Hp;


        Kiem.Atk = Kiemk;
        Khien.Atk = Khienk;
        CauBang.Atk = Caubangk;
        CuaPhat.Atk = TuongCuaPhat;
        Bom.Atk = Bombo;
        BangPha.Atk = Bangphak;
        ThuatThuc.Atk = Thuatthuck;
        ThanhKiem.Atk = Kiemthan;
        HpCharacter.Hp = Hpcharacter;
    }
    public void UpdateKiem()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            Kiemk++;
        }

    }
    public void UpdateKhien()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            Khienk++;
        }
    }
    public void UpdateCauBang()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            Caubangk++;
        }

    }
    public void UpdateCuaPhat()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            TuongCuaPhat++;
        }

    }
    public void UpdateBangPha()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            Bangphak++;
        }

    }
    public void UpdateBom()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            Bombo++;
        }

    }
    public void UpdateThuatThuc()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            Thuatthuck++;
        }
    }
    public void UpdateThanhKiem()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
          Kiemthan++;
        }

    }
    public void UpdateHp()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            Hpcharacter++;
        }

    }
    ///
    public int TuongCuaPhat
    {
        get => PlayerPrefs.GetInt("Cuaphat", CuaPhat.Atk);
        set => PlayerPrefs.SetInt("Cuaphat", value);
    }
    public int Caubangk
    {
        get => PlayerPrefs.GetInt("caubang", CauBang.Atk);
        set => PlayerPrefs.SetInt("caubang", value);
    }
    public int Bangphak
    {
        get => PlayerPrefs.GetInt("bangpha", BangPha.Atk);
        set => PlayerPrefs.SetInt("bangpha", value);
    }
    public int Khienk
    {
        get => PlayerPrefs.GetInt("khien", Khien.Atk);
        set => PlayerPrefs.SetInt("khien", value);
    }
    public int Kiemk
    {
        get => PlayerPrefs.GetInt("kiem", Kiem.Atk);
        set => PlayerPrefs.SetInt("kiem", value);
    }
    public int Kiemthan
    {
        get => PlayerPrefs.GetInt("kiemthan", ThanhKiem.Atk);
        set => PlayerPrefs.SetInt("kiemthan", value);
    }
    public int Thuatthuck
    {
        get => PlayerPrefs.GetInt("thuatthuc", ThuatThuc.Atk);
        set => PlayerPrefs.SetInt("thuatthuc", value);
    }
    public int Bombo
    {
        get => PlayerPrefs.GetInt("bom", Bom.Atk);
        set => PlayerPrefs.SetInt("bom", value);
    }
    public int Hpcharacter
    {
        get => PlayerPrefs.GetInt("hp",HpCharacter.Hp);
        set => PlayerPrefs.SetInt("hp", value);
    }
}
