using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    Rigidbody2D rd;
    Animator animskill;
    [SerializeField] float Speed;
    bool Checkdow;
    [Range(1f,20f)]
    [SerializeField] float MaxLeght;
    public LayerMask Play;
    public Vector2 Limit;
    AudioSource Audio;
    void Start()
    {
        Audio = GetComponent<AudioSource>();    
        rd=GetComponent<Rigidbody2D>();
        animskill=GetComponent<Animator>();
        if (transform.position.x < Limit.x || transform.position.x > Limit.y)
        {
            enable = true;
        }
    }  
    float skillDisable;
    public bool enable;
    float a;
    public void Setleftright(float i)
    {
        a = i;
    }
    void Update()
    {
        if(transform.position.x >= Limit.x||transform.position.x<=Limit.y)
        {
            enable=false;
        }
        if (enable)
        {
            rd.velocity = new Vector2(-a,rd.velocity.y) * Speed * Time.deltaTime;
        }
        if (!enable)
        {
            if (transform.position.x >= Limit.x)
            {
                animskill.SetFloat("Skill", 0);
                rd.velocity = new Vector2(-1, rd.velocity.y) * Speed * Time.deltaTime;
            }
             if (transform.position.x <= Limit.y)
            {
                animskill.SetFloat("Skill", 0);
                rd.velocity = new Vector2(1, rd.velocity.y) * Speed * Time.deltaTime;
            }
        }

        Checkdow = Physics2D.Raycast(transform.position, Vector2.down, MaxLeght, Play);
       
        if (Checkdow)
        {
            animskill.SetFloat("Skill", 1);
            
        }
    }
    bool skillskill;
    float d;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * MaxLeght);
    }
    public void Soudplay()
    {
        Audio.Play();
    }
    public void skilldisenable()
    {
        d++;
        if (d == 3)
        {
            gameObject.SetActive(false);
            d = 0;
        }
    }
}
