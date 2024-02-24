using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public PoolingBulet Poolingplayer;
    public static Player ChangerMessenger;
    public AtribuidHandDel atribui;
    public CharacterData characterData;
    [SerializeField] ParticleSystem partycel;
    [SerializeField] AudioSource SoundCoint;
    private void Awake()
    {
        if (ChangerMessenger == null)
        {
            ChangerMessenger = this;
        }
        else
        {
            DestroyImmediate(ChangerMessenger);
        }
        atribui = new AtribuidHandDel(characterData);
        atribui.Init();
    }
    void Start()
    {
    }
    float dem;
    // Update is called once per frame
    void Update()
    {
        if (atribui.CurrunHp<= 0)
        {
            DiePlayer();
            atribui.CurrunHp= 0;
        }
        if (Checkcount)
        {
            Count += Time.deltaTime;
            if (Count > 0 && Count < 5)
            {
                partycel.Play();
                atribui.CurrunHp += 1;
                if (atribui.CurrunHp> characterData.Hp)
                {
                    atribui.CurrunHp = characterData.Hp;
                }
            }
            if (Count >=5)
            {
                partycel.Stop();
                Count = 0;
                Checkcount = false;
            }


        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.TryGetComponent(out EnemyControlerGame gameControler);
            atribui.TakenDame(gameControler.atribuidHandDel.GetDameAtk, (die) =>
            {
            });
        }
        if (collision.CompareTag("KyNang"))
        {
            collision.TryGetComponent(out KyNangAttack atk);
            atribui.TakenDame(atk.DameSkill, (die) =>
            {
            });
        }
        if (collision.CompareTag("Trap"))
        {
            collision.TryGetComponent(out KyNangAttack kn);
            atribui.TakenDame(kn.DameSkill, (die) =>
            {
            });
        }

    }
    float Dem2;
    float Dem4;
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.CompareTag("KyNang"))
        {
            Dem2 += Time.deltaTime;
            if (Dem2 > 1.6f)
            {
                collision.TryGetComponent(out KyNangAttack att);
                atribui.TakenDame(att.DameSkill, (die) =>
                {
                    
                    
                });
                Dem2 = 0;
            }

        }
        if (collision.CompareTag("Enemy"))
        {
            Dem4 += Time.deltaTime;
            if (Dem4 > 1.6)
            {
                collision.TryGetComponent(out EnemyControlerGame gameControler);
                atribui.TakenDame(gameControler.atribuidHandDel.GetDameAtk, (die) =>
                {
                });
                Dem4 = 0;
            }
        }
    }
    float Count;
    bool Checkcount=false;
    public void DowbuttonDau()
    {
        Manager.Instance.SoundHp.Play();
        Checkcount = true;
        PlayerprefFruit.instanFruit.userbuttonDau();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coint"))//tang vang .,?Nang cap
        {
            SoundCoint.Play();
            collision.gameObject.SetActive(false);
            characterData.PlayerLevelCoin++;

        }
        //
        if (collision.gameObject.CompareTag("Tao"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddTao();
        }
        //
        if (collision.gameObject.CompareTag("Chuoi"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddChuoi();
        }
        //
        if (collision.gameObject.CompareTag("Le"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddLe();
        }
        //
        if (collision.gameObject.CompareTag("Nho"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddNho();
        }
        //
        if (collision.gameObject.CompareTag("Bo"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddBo();
        }
        //
        if (collision.gameObject.CompareTag("Cam"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddCam();
        }
        //
        if (collision.gameObject.CompareTag("Dau"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddDau();
        }
        //
        if (collision.gameObject.CompareTag("CuCai"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddCuCai();
        }
        //
        if (collision.gameObject.CompareTag("BapCai"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddBapCai();
        }
        //
        if (collision.gameObject.CompareTag("DuiGa"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddDuiGa();
        }
        //
        if (collision.gameObject.CompareTag("CaRot"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddCaRot();
        }
        //
        if (collision.gameObject.CompareTag("CaChua"))
        {
            Manager.Instance.SoundItem.Play();
            PlayerprefFruit.instanFruit.AddCaChua();
        }
        //
        if (collision.gameObject.CompareTag("KyNang"))
        {
            collision.gameObject.TryGetComponent(out KyNangAttack atk);
            atribui.TakenDame(atk.DameSkill, (die) =>
            {
            });
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.TryGetComponent(out EnemyControlerGame gameControler);
            atribui.TakenDame(gameControler.atribuidHandDel.GetDameAtk, (die) =>
            {
            });
        }
    }
    float Dem3;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("KyNang"))
        {
            Dem3 += Time.deltaTime;
            if (Dem3 > 1.6f)
            {
                collision.gameObject.TryGetComponent(out KyNangAttack att);
                atribui.TakenDame(att.DameSkill, (die) =>
                {

                });
                Dem3 = 0;
            }

        }
    }
    public void DiePlayer()
    {
        Manager.Instance.Loss();
        gameObject.SetActive(false);
    }
}
