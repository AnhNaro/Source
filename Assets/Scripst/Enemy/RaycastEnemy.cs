using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RaycastEnemy : MonoBehaviour
{
    public bool RayCheck;
    public bool RayCheck2;
    public LayerMask Play;
    [Range(1f, 20f)] 
    public float LenghtCast;
    [SerializeField] float Speedmove;
    public int localx,localy;   
    Rigidbody2D rd;
    public PoolingBulet Poo;
    [SerializeField] Transform a1;
    [SerializeField] Transform a2;
    Vector2 a12;
    AudioSource Audio;
    void Start()
    {
        Audio=GetComponent<AudioSource>();
       transform.position=new Vector2(localx,transform.position.y); 
        rd = GetComponent<Rigidbody2D>();
    }
    float ii;
    void Update()
    {
        ii += Time.deltaTime;
        a12 = a2.position - a1.position;
        if(RayCheck && transform.localScale.x>0|| RayCheck2 && transform.localScale.x<0)
        {
            if(ii>0.3f)
            {
                Shoot();
                ii = 0;
            }
        }

#if true//ray player

        if (transform.position.x >= localx)
        {
            rd.velocity = Vector2.left * Speedmove;
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (transform.position.x <= localy)
        {
            rd.velocity = Vector2.right * Speedmove;
            transform.localScale = new Vector3(-1, 1, 1);
        } 
#endif
#if true//speed
        RayCheck2 = Physics2D.Raycast(transform.position, Vector2.right, LenghtCast, Play);
        RayCheck = Physics2D.Raycast(transform.position, Vector2.left, LenghtCast, Play);
        if (RayCheck || RayCheck2)
        {
            Speedmove = 5;
        }
        else
            Speedmove = 3; 
#endif

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,transform.position + Vector3.left*LenghtCast);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * LenghtCast);
    }
    public void Shoot()
    {
        Audio.Play();
        GameObject Go = Poo.Getpool();
        Go.SetActive(true);
        Go.TryGetComponent(out BulletEnemy bu);
        bu.transform.position = a1.transform.position;
        bu.SetTran(a12);
    } 
   
   

}
