using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hp : MonoBehaviour
{
    public Image fillimage;
    public EnemyControlerGame enem;
    public float hp;
    public float hp2;
    private void Start()
    {
        fillimage=GetComponent<Image>();
        hp = enem.atribuidHandDel.CurrunHp;
    }
    private void FixedUpdate()
    {
        hp = enem.atribuidHandDel.CurrunHp;
        hp2 = hp / enem.characterData.Hp;
        fillimage.fillAmount = hp2;
    }
    private void Update()
    {
    }
}
