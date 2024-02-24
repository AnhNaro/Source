using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawSkeleton : MonoBehaviour
{
    [SerializeField] float i;
    Rigidbody2D rd;
    [Range(1f, 100f)]
    [SerializeField] float Maxx;
    public LayerMask Play;
    [SerializeField] float Speed;
    public GameObject Player;
    Animator anim;
    bool CheckLeft;
    bool CheckRinght;
    public Vector2 Limit;
    private void Awake()
    {
        anim=GetComponent<Animator>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (!CheckLeft&&!CheckRinght)
        {
            if (transform.position.x >= Limit.x)
            {
                anim.SetFloat("Skeanim", 1);
                rd.velocity = Vector2.left * Speed;
                transform.localScale = new Vector3(i,0.7f,0.7f);
            }
            else if (transform.position.x <= Limit.y)
            {
                anim.SetFloat("Skeanim", 1);
                rd.velocity = Vector2.right * Speed;
                transform.localScale = new Vector3(-i,0.7f,0.7f);
            }
        }
        if (BoCheck)
        {
            if (CheckLeft)
            {
                anim.SetFloat("Skeanim", 1);
                rd.velocity = Vector2.left * Speed;
                transform.localScale = new Vector3(i,0.7f,0.7f);
            }
            if (CheckRinght)
            {
                anim.SetFloat("Skeanim", 1);
                rd.velocity = Vector2.right * Speed;
                transform.localScale = new Vector3(-i,0.7f,0.7f);
            }

        }
    }
    Vector2 Direct;
    [SerializeField] bool BoCheck;
    bool Check=true;
    float Timec;
    // Update is called once per frame
    void Update()
    {
        if (Check)
        {
            anim.SetFloat("Skeanim", 0);
            Timec += Time.deltaTime;
            if (Timec > 1.5f)
            {
                Check=false;
            }
        }
        Direct = Player.transform.position-transform.position;
        float io = Direct.SqrMagnitude();
     
        if (io>5&& Check==false)
        {
            BoCheck = true;
        }
        else
        {
            BoCheck = false;
        }
       
        CheckLeft=Physics2D.Raycast(transform.position,Vector2.left,Maxx,Play);
        CheckRinght=Physics2D.Raycast(transform.position,Vector2.right,Maxx,Play);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,transform.position+Vector3.left*Maxx);
        Gizmos.DrawLine(transform.position,transform.position+Vector3.right*Maxx);
    }
}
