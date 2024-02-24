using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBoss : MonoBehaviour
{
    public EnemyControlerBossGame eneboss;
     float hp1;
     float hp2;
    public Image fillhp;
    void Start()
    {
        hp1 = eneboss.atribuidHandDel2.CurrunHp;
        fillhp=GetComponent<Image>();
    }
    private void FixedUpdate()
    {
        hp1 = eneboss.atribuidHandDel2.CurrunHp;
        hp2 = hp1 / eneboss.characterData.Hp;
        fillhp.fillAmount = hp2;
    }
}
