using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    public GameObject Trainf;
    public static PlayerControler instance; 
    Rigidbody2D rd;
    [SerializeField] float MoveSpeedPlayer;
    public Animator animator;
    [SerializeField]float JumpPlayer;
    [Header("Check")]
    [SerializeField] bool CheckGround;
    [SerializeField]Transform poitgroundcheck;
    [SerializeField]LayerMask Ground;
    Vector2 Gaverity;
    [SerializeField] float Smoothjump;
    private void Awake()
    {
            instance = this;
    }
    void Start()
    {
        rd=GetComponent<Rigidbody2D>();
        Gaverity = new Vector2(0, -Physics2D.gravity.y);
    }
    private void FixedUpdate()
    {
        rd.velocity=new Vector2(xplay*MoveSpeedPlayer,rd.velocity.y);
        animator.SetFloat("XHorizo",Mathf.Abs(xplay));
        animator.SetFloat("YVerti", rd.velocity.y);
    }
    float xplay;
    void Update()
    {
        CheckGround = Physics2D.OverlapBox(poitgroundcheck.position, new Vector2(1f, 0.19f), 0, Ground);
        animator.SetBool("Jump", !CheckGround);
        if (rd.velocity.y < 0 && !CheckGround)
        {
            rd.velocity -=  Gaverity * Smoothjump * Time.deltaTime;
        }
        Plip();
      
    }
    void Plip()
    {
        if (xplay> 0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if(xplay < -0.1f)
        {
            transform.localScale=new Vector3(-1, 1, 1);
        }
    }
    public void BtnMoveLeftDow()
    {
        xplay = -1;
        Trainf.SetActive(true);
    }
    public void BtnMoveLeftUp()
    {
        xplay = 0;
    }

    public void BtnMoveRightDow()
    {
        xplay = 1;
        Trainf.SetActive(true);
    }
    public void BtnMoveRightUp()
    {
        xplay = 0;
    }
    public void BtnMoveUp()
    {
        Manager.Instance.SoundJump.Play();
        if (CheckGround)
        {
            rd.velocity = new Vector2(rd.velocity.x, JumpPlayer);
            Trainf.SetActive(false);
        }
    }
}
