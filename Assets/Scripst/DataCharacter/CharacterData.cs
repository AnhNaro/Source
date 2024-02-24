using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Creat Character",menuName ="New Character")]
public class CharacterData : ScriptableObject
{
    public Tag tagcharacter;
    public int Hp;
    public int Atk;
    public void TangCoin()// Cham vao Itemp tang coin va luu vao so vang
    {
        PlayerLevelCoin++;
    }
    public int PlayerLevelCoin// tao bien luu gia tri vang
    {
        get => PlayerPrefs.GetInt(tagcharacter.ToString(), 50);
        set => PlayerPrefs.SetInt(tagcharacter.ToString(), value);
    }
}
public enum Tag
{
    Character,
    Enemy,
}