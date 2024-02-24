using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlerBossGame : MonoBehaviour
{
    [SerializeField] GameObject LoCauVong;
    public AtribuidHandDel atribuidHandDel2;
    public CharacterData characterData;
    Collider2D collider;
    private void Awake()
    {
        atribuidHandDel2 = new AtribuidHandDel(characterData);
      
    }
    // Start is called before the first frame update
    void Start()
    {
        atribuidHandDel2.Init();
        collider=GetComponent<Collider2D>();
    }

    // Update is called once per frame
    float al;
    void Update()
    {
        if (atribuidHandDel2.CurrunHp <= 0)
        {
            DieEnemy();
        }
        if (collider.isTrigger == false)
        {
            al += Time.deltaTime;
            if (al > 1)
            {
                collider.isTrigger = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("KiemD"))
        {
            Debug.Log("Kiem");
            collision.TryGetComponent(out KyNangAttack character);
            atribuidHandDel2.TakenDame(character.DameSkill, (die) =>
            {

            });

        }
        if (collision.CompareTag("KhienD"))
        {
            Debug.Log("Khien");
            collision.TryGetComponent(out KyNangAttack Atk);
            atribuidHandDel2.TakenDame(Atk.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("BangPha"))
        {
            collision.TryGetComponent(out KyNangAttack Bp);
            atribuidHandDel2.TakenDame(Bp.DameSkill, (die) =>
            {

            });
            Staybangpha();
        }
        if (collision.CompareTag("ThuatThuc"))
        {
            collision.TryGetComponent(out KyNangAttack Thuatthuc);
            atribuidHandDel2.TakenDame(Thuatthuc.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("CauBang"))
        {
            collision.TryGetComponent(out KyNangAttack CauB);
            atribuidHandDel2.TakenDame(CauB.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("Lua"))
        {
            collision.TryGetComponent(out KyNangAttack Lua);
            atribuidHandDel2.TakenDame(Lua.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("BongBong"))
        {
            collision.TryGetComponent(out KyNangAttack BB);
            atribuidHandDel2.TakenDame(BB.DameSkill, (die) =>
            {

            });
        }
        if (collision.CompareTag("KiemThan"))
        {
            collision.TryGetComponent(out KyNangAttack KT);
            atribuidHandDel2.TakenDame(KT.DameSkill, (die) =>
            {

            });
        }

    }
    public void DieEnemy()
    {    
        GameObject Clone = Instantiate(LoCauVong, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
    float ii;
    void Staybangpha()
    {
        ii += Time.deltaTime;
        if (ii > 1)
        {
            atribuidHandDel2.TakenDame(5, (die) =>
            {

            });
            ii = 0;
        }
    }
}
