using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyControlerGame : MonoBehaviour
{
    public AtribuidHandDel atribuidHandDel;
    public CharacterData characterData;
    public ItemPooling Spawitem;
     Collider2D collider;
    private void Awake()
    {
        atribuidHandDel = new AtribuidHandDel(characterData); 
        atribuidHandDel.Init();

    }   // Start is called before the first frame update
    void Start()
    {
       collider=GetComponent<Collider2D>();
    }

    // Update is called once per frame
     float a;
    void Update()
    {
      
        if (atribuidHandDel.CurrunHp <= 0)
        {
           
            DieEnemy();
        }
        if (collider.isTrigger == false)
        {
            a += Time.deltaTime;
            if (a > 1)
            {
                collider.isTrigger = true;
                a=0;
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
            if (collision.CompareTag("KiemD"))
            {
                collision.TryGetComponent(out KyNangAttack character);
            atribuidHandDel.TakenDame(character.DameSkill, (die) =>
            {
              
            });
            
            }
        if (collision.CompareTag("KhienD"))
        {
            collision.TryGetComponent(out KyNangAttack Atk);
            atribuidHandDel.TakenDame(Atk.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("BangPha"))
        {
            collision.TryGetComponent(out KyNangAttack Bp);
            atribuidHandDel.TakenDame(Bp.DameSkill, (die) =>
            {

            });
            Staybangpha();
        }
        if (collision.CompareTag("ThuatThuc"))
        {
            collision.TryGetComponent(out KyNangAttack Thuatthuc);
            atribuidHandDel.TakenDame(Thuatthuc.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("CauBang"))
        {
            collision.TryGetComponent(out KyNangAttack CauB);
            atribuidHandDel.TakenDame(CauB.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("Lua"))
        {
            collision.TryGetComponent(out KyNangAttack Lua);
            atribuidHandDel.TakenDame(Lua.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("BongBong"))
        {
            collision.TryGetComponent(out KyNangAttack BB);
            atribuidHandDel.TakenDame(BB.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("KiemThan"))
        {
            collision.TryGetComponent(out KyNangAttack KT);
            atribuidHandDel.TakenDame(KT.DameSkill, (die) =>
            {

            });
        }
    }
    public void DieEnemy()
    {    
        GameObject Clo=Instantiate(Spawitem.Getitempooling(),transform.position,Quaternion.identity);
        gameObject.SetActive(false);
    }
    float ii;
    void Staybangpha()
    {
        ii += Time.deltaTime;
        if (ii >1)
        {
            atribuidHandDel.TakenDame(4, (die) =>
            {

            });
            ii = 0;
        }
    }

}
