using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    public PoolingBulet poBoss;
    [SerializeField] Transform Skillki;
    [Range(1f, 100f)]
    [SerializeField] float MaxLenght;
    public LayerMask Play;
    bool Left;
    bool Right;
    [SerializeField] Transform Player;
    [SerializeField] Transform BossTransform;
    [SerializeField] int RangerAttack;
    Vector2 Direct;
    Rigidbody2D rd;
    Animator animboss;
    [SerializeField] float MoveSpeed;
    AudioSource Audio;
    public AudioSource Audio2;
    private void Awake()
    {
        animboss = GetComponent<Animator>();    
        rd = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
     bool Enable;
    private void FixedUpdate()
    {
        if (Enable)
        {
            if (Left)
            {
                animboss.SetFloat("BossSim", 1);
                rd.velocity = Vector2.left * MoveSpeed * Time.deltaTime;
                transform.localScale = new Vector3(2,2,2);
                CountSkillboss++;
            }
            else if (Right)
            {
                animboss.SetFloat("BossSim", 1);
                rd.velocity = Vector2.right * MoveSpeed * Time.deltaTime;
                transform.localScale = new Vector3(-2,2,2);
                CountSkillboss++;
            }
            else
            {
                animboss.SetFloat("BossSim", 0);
            }
        }
    }
    float Move;
   public float Skill;
   public float Skill2;
    float Attack1;
    float ab;
   public float a;
    float b;
    float c;
    bool Kch;
    float CountSkillboss;
    void Update()
    {
        Move += Time.deltaTime;
        if (Move > 10&&a>RangerAttack&&(Left||Right))
        {
            Enable = false;
            animboss.SetFloat("BossSim", 2);
            rd.velocity = Direct *new Vector2(1,rd.velocity.y)* MoveSpeed * Time.deltaTime;
            Kch = true;
            if (Kch)
            {
                ab += Time.deltaTime;
                if (ab > 1.5f)
                {
                    Move = 0;
                    ab = 0;
                }
            }
        }
        Direct=Player.position-BossTransform.position;
        a = Direct.sqrMagnitude;
        Attack1 += Time.deltaTime;
        if (a < RangerAttack && Attack1 >2)
        {
            Enable = false;
            animboss.SetFloat("BossSim", 3);
            if (Left)
            {
                transform.localScale = new Vector3(2,2,2);
            }
            if (Right)
            {
                transform.localScale = new Vector3(-2,2,2);
            }
            Attack1 = 0;
        }
        else if (a > RangerAttack) Enable = true;
        if (CountSkillboss>=1&&a>30)
        {
            Skill += Time.deltaTime;
            if (Skill > 20)
            {
                Enable=false;
                c += Time.deltaTime;
                animboss.SetFloat("BossSim", 4);
                if (c > 2)
                {
                    Skill = 0;
                    c = 0;
                }
            }
        }
        if (CountSkillboss>=1&&a<26)
        {
            Skill2 += Time.deltaTime;
            if (Skill2 > 40)
            {
                Enable = false;
                b += Time.deltaTime;
                animboss.SetFloat("BossSim", 4);
                if (b > 2)
                {
                    Skill2 = 0;
                    b = 0;
                }
            }
        }
      
        Left =Physics2D.Raycast(BossTransform.position,Vector2.left,MaxLenght,Play);
        Right=Physics2D.Raycast(BossTransform.position,Vector2.right,MaxLenght,Play);



    }
    public void Skillkill()
    {
        GameObject Clone = poBoss.Getpool();
            Clone.SetActive(true);
        Clone.transform.localScale = new Vector3(4,4,4);
            Clone.transform.position = Skillki.transform.position;
        Clone.TryGetComponent(out Skill tk);
        tk.Setleftright(transform.localScale.x);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(BossTransform.position,BossTransform.position+Vector3.left*MaxLenght);
        Gizmos.DrawLine(BossTransform.position,BossTransform.position+Vector3.right*MaxLenght);
    }
    public void SoundPlay()
    {
        Audio.Play();
    }
    public void Sound2play()
    {
        Audio2.Play();
    }
}
