using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyNangAttack : MonoBehaviour
{
   public int DameSkill;
    public CharacterData CharacterData;
    private void Awake()
    {
        DameSkill = CharacterData.Atk;
    }
}
