using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class By : MonoBehaviour
{
    public Text txtanimgold;
    public TextMeshProUGUI CointHome;
    public TextMeshProUGUI CointHome2;
    [SerializeField] Text NgayGio;
    // Start is called before the first frame update
    void Start()
    {
        CointHome.text = Player.ChangerMessenger.characterData.PlayerLevelCoin.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        NgayGio.text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        CointHome.text = Player.ChangerMessenger.characterData.PlayerLevelCoin.ToString();
        CointHome2.text = Player.ChangerMessenger.characterData.PlayerLevelCoin.ToString();

    }
    public void ByShopTao()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >=1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            PlayerprefFruit.instanFruit.AddTao();
        }

    }
    public void ByShopCam()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            PlayerprefFruit.instanFruit.AddCam();
        }

    }
    public void ByShopDau()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            PlayerprefFruit.instanFruit.AddDau();
        }

    }
    public void ByShopBo()
    {
        txtanimgold.gameObject.SetActive(false);
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin < 1)
        {
            txtanimgold.gameObject.SetActive(true);
        }
        if (Player.ChangerMessenger.characterData.PlayerLevelCoin >= 1)
        {
            Player.ChangerMessenger.characterData.PlayerLevelCoin--;
            PlayerprefFruit.instanFruit.AddBo();
        }

    }

}
