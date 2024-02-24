using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapCircel : MonoBehaviour
{
    Animator animator;
    [SerializeField] bool CheckOver;
    [SerializeField] bool CheckOver2;
    [SerializeField] bool CheckOver3;
    [Range(1f, 18f)]
    public float Ran;
    public LayerMask play;
    Vector2 tranpoit;
    public int f;
    public Transform A, B;
    Vector2 aa;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        tranpoit = A.position;
        aa=transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        CheckOver = Physics2D.Raycast(transform.position, Vector2.left, Ran, play);
        CheckOver2 = Physics2D.Raycast(transform.position, Vector2.right, Ran, play);
       

        if (Vector2.Distance(transform.position, A.position) < 0.5f)
        {
            tranpoit=B.position;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if(Vector2.Distance(transform.position, B.position) < 0.1f)
        {
            tranpoit=A.position;
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (CheckOver || CheckOver2)
        {
            CheckOver3 = true;
            animator.Play("Flying");
            transform.position = Vector2.MoveTowards(transform.position, tranpoit, f * Time.deltaTime);
        }
        if(CheckOver3 && !CheckOver&&!CheckOver2)
        { 
            animator.Play("Flying");
            transform.position = Vector2.MoveTowards(transform.position, tranpoit, f * Time.deltaTime);
        }
     
      
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left * Ran);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * Ran);
    }
}
