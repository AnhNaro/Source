using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UserNameandCode : MonoBehaviour
{
    public TextMeshProUGUI textname;
    public TMP_InputField Username;
    public TMP_InputField Password;
    [SerializeField] Text Hpplayer;
    [SerializeField] Image HpplayerImage;
    public float hp;
    public Gradient graddien;
    private void Awake()
    {
        Username.text = Savename;
        textname.text=Username.text;
    }
    private void Start()
    {
        hp = Player.ChangerMessenger.characterData.Hp;
        HpplayerImage.color = graddien.Evaluate(1f);
    }
    private void Update()
    {
        Hpplayer.text = Player.ChangerMessenger.atribui.CurrunHp.ToString();
        HpplayerImage.fillAmount = Player.ChangerMessenger.atribui.CurrunHp / hp;
        HpplayerImage.color = graddien.Evaluate(HpplayerImage.fillAmount);
    }
    public void btnSaveName()
  {
     Savename=Username.text;
        textname.text =Savename;
  }
    public void btnGetCode()
    {
        if (SaveCode < 1)
        {
            if (Password.text == "Plus")
            {
                SaveCode++;
                Player.ChangerMessenger.characterData.PlayerLevelCoin += 50;
            }
            if (Password.text == "QT")
            {
                SaveCode++;
                Player.ChangerMessenger.characterData.PlayerLevelCoin += 300;
            }
        }
    }
    public string Savename
    {
        get => PlayerPrefs.GetString("Name");
        set => PlayerPrefs.SetString("Name", value);
    }
    public int SaveCode
    {
        get => PlayerPrefs.GetInt("Code", 0);
        set => PlayerPrefs.SetInt("Code", value);
    }
}
