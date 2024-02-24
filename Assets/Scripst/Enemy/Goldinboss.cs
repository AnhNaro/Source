using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;
using UnityEngine;
public class Goldinboss : MonoBehaviour
{
    public PoolingBulet pooruu;
    public GameObject Playergame;
    Rigidbody2D rd;
    bool Check1;
    bool Check2;
    [Range(1f,50f)]
    [SerializeField] float Max;
    public LayerMask Player;
    public Animator Anim;
    [SerializeField] float Speed;
    Vector2 Mangitur;
    [Range(1f,500f)]
    [SerializeField] float Ranger;
    [SerializeField] GameObject RuuGoldin;
    [SerializeField] Transform poitnemruu;
    [SerializeField] Transform Huongruu;
    Vector2 Direct;
    AudioSource Audio;
    public AudioSource Audio2;
    void Start()
    {
        Audio=GetComponent<AudioSource>();  
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
     float dem;
     float kcach;
    bool check12;
    void Update()
    {
        Mangitur=transform.position-Playergame.transform.position;
        kcach = Mangitur.SqrMagnitude();
        Direct = Huongruu.position - transform.position;
        Check1 = Physics2D.Raycast(transform.position, Vector2.left, Max, Player);
        Check2 = Physics2D.Raycast(transform.position, Vector2.right, Max, Player);
        if (kcach<Ranger)
        {
            check12 = false;
        }
        else
        {
            check12 = true;
        }
        if (!check12)
        {

            if (Check1)
            {
                dem += Time.deltaTime;
                Anim.SetFloat("IRAHanim", 2);
                transform.localScale = new Vector3(-2, 2, 2);

                if (dem > 1)
                {
                    Nemruu();
                    dem = 0;
                }
            }
            else if (Check2)
            {
                dem += Time.deltaTime;
                Anim.SetFloat("IRAHanim", 2);
                transform.localScale = new Vector3(2,2,2);
                if (dem > 1)
                {
                    Nemruu();
                    dem = 0;
                }
                if(dem < 1)
                {
                    Audio2.Play();
                }
            }
        }
        else
        {
            if (Check1)
            {
                Anim.SetFloat("IRAHanim", 1);
                rd.velocity = Vector2.left * Speed * Time.deltaTime;
                transform.localScale = new Vector3(-2,2,2);
            }
            else if (Check2)
            {
                Anim.SetFloat("IRAHanim", 1);
                rd.velocity = Vector2.right * Speed * Time.deltaTime;
                transform.localScale = new Vector3(2, 2,2);
            }
            else
            {
                Anim.SetFloat("IRAHanim", 0);
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left * Max);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * Max);      
    }
   public void Nemruu()
    {
        Audio.Play();
        GameObject cl = pooruu.Getpool();
        cl.gameObject.SetActive(true);
        cl.TryGetComponent(out BulletEnemy ruu);
        ruu.transform.localScale = transform.localScale;
        ruu.transform.position=poitnemruu.transform.position;   
        ruu.SetTran(Direct);
    }
}
