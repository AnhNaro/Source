using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimmove : MonoBehaviour
{
    [SerializeField] GameObject Play;
    Rigidbody2D rd;
    bool Check1;
     bool Check2;
    [Range(1f, 100f)]
    [SerializeField] float Max;
    public LayerMask Player;
     Animator Animslim;
    [SerializeField] float Speed;
    Vector3 Mangitur;
    [Range(1f, 15f)]
    [SerializeField] float RanQ;
    public Transform colision;
    public float Skillground;
    Vector2 III;
    AudioSource Audio;
    private void Awake()
    {
        Animslim = GetComponent<Animator>();
    }
    void Start()
    {
        Audio = GetComponent<AudioSource>();    
        rd=GetComponent<Rigidbody2D>();
        Animslim.SetFloat("Slim",0);
        III=new Vector2(transform.position.x, transform.position.y);
    }
    float Dd;
    // Update is called once per frame
    void Update()
    {
        Check1 = Physics2D.Raycast(transform.position, Vector2.left, Max, Player);
        Check2 = Physics2D.Raycast(transform.position, Vector2.right, Max, Player);

        Mangitur = Play.transform.position - transform.position;
        Dd = Mangitur.sqrMagnitude;
       
            if (Dd <= RanQ)
            {

                Animslim.SetFloat("Slim", 2);
                colision.gameObject.SetActive(true);
                transform.position = new Vector2(transform.position.x, Skillground);
                if (Check1)
                {
                    Speed = 5f;
                    rd.velocity = Vector2.left * Speed;
                }
                if(Check2)
                {
                    Speed = 5f;
                    rd.velocity = Vector2.right * Speed;
                }
            }
        
        else
        {
            Speed = 100f;
            colision.gameObject.SetActive(false);
            transform.position = new Vector2(transform.position.x,III.y);
            if (Check1)
            {
                Animslim.SetFloat("Slim", 1f);
                rd.velocity = new Vector2(-1, rd.velocity.y) * Speed * Time.deltaTime;
                transform.localScale = new Vector3(-2, 2, 1);

            }
            else if (Check2)
            {
                Animslim.SetFloat("Slim", 1f);
                rd.velocity = new Vector2(1, rd.velocity.y) * Speed * Time.deltaTime;
                transform.localScale = new Vector3(2, 2, 1);
            }
            else
            {
                Animslim.SetFloat("Slim", 0);
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left * Max);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * Max);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Audio.Play();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Audio.Play();
        }
    }
}

