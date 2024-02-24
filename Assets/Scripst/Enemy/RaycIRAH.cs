using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycIRAH : MonoBehaviour
{
    [SerializeField] GameObject Play;
    Rigidbody2D rd;
    bool Check1;
    bool Check2;
    [Range(1f,50f)]
    [SerializeField] float Max;
    public LayerMask Player;
     Animator Anim;
    [SerializeField] float Speed;
    Vector2 Mangitur;
    [Range(1f,500f)]
    [SerializeField] float Ranger;
    [SerializeField] GameObject colision;
    AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
        Audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
     float Dd;
    void Update()
    {
        Check1 = Physics2D.Raycast(transform.position, Vector2.left, Max, Player);
        Check2 = Physics2D.Raycast(transform.position, Vector2.right, Max, Player);
       
        Mangitur = transform.position-Play.transform.position;
        Dd = Mangitur.sqrMagnitude;
      
            if (Dd < Ranger && Check1)
            {

                Anim.SetFloat("IRAHanim", 2);
                transform.localScale = new Vector3(2, 2, 2);
            }
               
            if(Dd< Ranger && Check2)
            {
                Anim.SetFloat("IRAHanim", 2);
                transform.localScale = new Vector3(-2, 2, 2);
            }
        if (Dd > Ranger)
        {
            Checktrue();
            
        }

    }
    public void Checktrue()
    {
        if(Check1)
        {
            Anim.SetFloat("IRAHanim", 1);
            rd.velocity=Vector2.left*Speed*Time.deltaTime;
            transform.localScale = new Vector3(2, 2, 2);

        }
        else if (Check2)
        {
            Anim.SetFloat("IRAHanim", 1);
            rd.velocity = Vector2.right * Speed*Time.deltaTime;
            transform.localScale = new Vector3(-2, 2, 2);
        }
        else
        {
            Anim.SetFloat("IRAHanim", 0);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left * Max);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * Max);      
    }
    //tacke
    public void cllosionEnable()
    {

        colision.gameObject.SetActive(true);
        Audio.Play();

    }
    public void CollionDisenable()
    {
        colision.gameObject.SetActive(false);
    } 
   
}
