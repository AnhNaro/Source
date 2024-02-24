using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class XuongBoss : MonoBehaviour
{
    [SerializeField] float MoveSpeed;
    Rigidbody2D rd;
    Animator animator;
    public LayerMask Player;
    public Transform ObjectPlay;
    public Transform BossTranform;
    bool CheckL;
    bool CheckR;
    [SerializeField] bool Box;
    [Range(1f, 90f)]
    [SerializeField] float Maxlenght;
    Vector2 Direct;
    bool Enable;
    Collider2D Collider;
    AudioSource Audio;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        Audio=GetComponent<AudioSource>();
        Collider = GetComponent<Collider2D>();
    }
    public float a;
    float ii;
    float colidereneEnab;
    void Update()
    {
        if(Collider.isTrigger == false)
        {
            colidereneEnab += Time.deltaTime;
            if(colidereneEnab > 4)
            {
                Collider.isTrigger = true;
                colidereneEnab = 0;
            }
         

        }
        ii += Time.deltaTime;
        Direct=ObjectPlay.transform.position-BossTranform.position;
         a = Direct.sqrMagnitude;
        CheckL=Physics2D.Raycast(BossTranform.position,Vector2.left,Maxlenght,Player);
        CheckR=Physics2D.Raycast(BossTranform.position,Vector2.right,Maxlenght,Player);
        if (a >= 60&& a <=76)
        {
            Enable = false;
            if (ii > 2)
            {
                int b = Random.Range(3, 5);
                animator.SetFloat("Xuonganim", b);
                ii = 0;
            }
        }
        else if (a <60)
        {
            if (CheckL)
            {
                transform.localScale = new Vector3(-2, 2, 2);
            }
            else if(CheckR)transform.localScale = new Vector3(2, 2, 2);
            Enable = false;
            animator.SetFloat("Xuonganim", 4);
        }
        else
        {
            Enable = true;
        }
        if (!CheckL && !CheckR)
        {
            animator.SetFloat("Xuonganim", 0);
        }
        if (Enable)
        {
            if (CheckL)
            {
                animator.SetFloat("Xuonganim", 1);
                rd.velocity = Vector2.left * MoveSpeed * Time.deltaTime;
                transform.localScale = new Vector3(-2, 2, 2);
            }
            if (CheckR)
            {
                animator.SetFloat("Xuonganim", 1);
                rd.velocity = Vector2.right * MoveSpeed * Time.deltaTime;
                transform.localScale = new Vector3(2, 2, 2);
            }
        }


    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(BossTranform.position, BossTranform.position + Vector3.left * Maxlenght);
        Gizmos.DrawLine(BossTranform.position, BossTranform.position + Vector3.right * Maxlenght);

    }
    public void AuSound()
    {
        Audio.Play();
    }
}
