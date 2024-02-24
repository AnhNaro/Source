using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AtribuidHandDel
{
    Tag tag;
    private int Hp;
    private int Atk;
    public int CurrunHp;    
    public AtribuidHandDel(CharacterData character)
    {
        Hp = character.Hp;
        Atk = character.Atk;
        tag = character.tagcharacter;
    }
    public void Init()
    {
        CurrunHp = Hp;
    }
    public int GetDameAtk => Atk;
    public void TakenDame(int val,Action<bool> Die)
    {
        CurrunHp -= val;
        if (CurrunHp <= 0)
        {
            Die.Invoke(true);
        }
        else
        {
            Die.Invoke(false);
        }
    }
}
