using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhapsuControler : MonoBehaviour
{
    [SerializeField] PoolingBulet Pool;
    [SerializeField] bool Check1;
    [SerializeField] bool Check2;
    [SerializeField] LayerMask play;
    [Range(1f,50f)]
    [SerializeField] float Maxlenght;
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] Transform B2;
    [SerializeField] Transform B3;
    [SerializeField] Transform Shootpoit;
    public Transform HandFire;
    Animator animator;
    public GameObject LuaMove;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>(); 
    }

    Vector3 Anh;
    public bool Chy = true;
    public float Dem;
    void Update()
    {
        
        Anh=B2.position-B3.position;
        if (!Chy)
        {
            Dem += Time.deltaTime;
            if (Dem > 9)
            {
                animator.SetFloat("Phapsuanim", 0);
                if (Dem > 18)
                {
                    Chy = true;
                    Dem = 0;
                }
            }
        }
        Check1 = Physics2D.Raycast(A.transform.position,Vector2.right, Maxlenght, play);
        Check2 = Physics2D.Raycast(B.transform.position, Vector2.left, Maxlenght, play);
        if (Chy)
        {
            if (Check1)
            {
                animator.SetFloat("Phapsuanim", 1);
                transform.localScale = new Vector3(1, 1, 1);

            }
            else if (Check2)
            {
                animator.SetFloat("Phapsuanim", 1);
                transform.localScale = new Vector3(-1, 1, 1);

            }
            else
            {
                animator.SetFloat("Phapsuanim", 0);
            }
        }

    }
    public void Shootsu()
    {
        GameObject clon = Pool.Getpool();
        clon.SetActive(true);
        clon.TryGetComponent(out BulletEnemy buem);
        buem.transform.position=Shootpoit.transform.position;
        buem.transform.localScale = transform.localScale;
        buem.SetTran(Anh);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(A.position, A.position +Vector3.right * Maxlenght);
        Gizmos.DrawLine(B.position, B.position +Vector3.left * Maxlenght);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Chy = false;
            animator.SetFloat("Phapsuanim", 2);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Chy = true;
        }

    }
    public void SpawFireBall()
    {
        GameObject CLo = Instantiate(LuaMove, HandFire.position, Quaternion.identity);
        CLo.SetActive(true);
    }
}
