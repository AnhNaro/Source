using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveIRH : MonoBehaviour
{
    Rigidbody2D rd;
    bool C1;
    bool C2;
    [Range(0f, 60f)]
    [SerializeField] float Max;
    public LayerMask Player;
    public GameObject a;
    public GameObject b;
    [SerializeField] float SpeedOC;
    Animator animator;
    [SerializeField] int X, Y;
    bool impo;
    AudioSource Audio;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        Audio=GetComponent<AudioSource>();
        transform.position=new Vector2(X,transform.position.y);
        rd=GetComponent<Rigidbody2D>();
        animator.SetFloat("BaanimIRH", 0);
    }
    private void FixedUpdate()
    {
        if (!impo)
        {
            SpeedOC = 140f;
            i += Time.deltaTime;
            if (i > 3)
            {

                if (transform.position.x >= X)
                {
                    animator.SetFloat("BaanimIRH", 1);
                    rd.velocity = Vector2.left * SpeedOC * Time.deltaTime;
                    transform.localScale = new Vector3(2, 2, 1);
                }
                if (transform.position.x <= Y)
                {
                    animator.SetFloat("BaanimIRH", 1);
                    rd.velocity = Vector2.right * SpeedOC * Time.deltaTime;
                    transform.localScale = new Vector3(-2, 2, 1);
                   
                }


             
            }


        }
        //dy chuyen bang checkray
            if (C1)
            {
                impo=true;
                SpeedOC = 180f;
                animator.SetFloat("BaanimIRH", 1);
                rd.velocity = new Vector2(-1, 0) * SpeedOC*Time.deltaTime ;
                transform.localScale = new Vector3(2, 2, 1);
                
            }
            if (C2)
            {
            impo = true;
            SpeedOC = 180f;
                animator.SetFloat("BaanimIRH", 1);
                rd.velocity = new Vector2(1, 0) * SpeedOC*Time.deltaTime;
                transform.localScale = new Vector3(-2, 2, 1);
            }

    }
    float i;
    void Update()
    {
        impo=false;
        C1 = Physics2D.Raycast(a.transform.position,Vector2.left, Max, Player);
        C2 = Physics2D.Raycast(b.transform.position, Vector2.right, Max, Player);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(a.transform.position, a.transform.position + Vector3.left * Max);
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(b.transform.position, b.transform.position + Vector3.right * Max);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Audio.Play();
        }
    }
}
