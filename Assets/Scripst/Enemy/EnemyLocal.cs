using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLocal : MonoBehaviour
{
    public PoolingBulet poo;
    [SerializeField] Transform a, b;
    Animator anim;
    [SerializeField] bool check;
    [SerializeField] bool check2;
    public LayerMask layer;
    [Range(1f,50f)]
    [SerializeField] float Max;
    AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();    
    }
    Vector2 aa;
    // Update is called once per frame
    void Update()
    {
       aa=a.transform.position-b.transform.position;
        check=Physics2D.Raycast(b.transform.position,Vector2.left,Max,layer);
        check2=Physics2D.Raycast(b.transform.position,Vector2.right,Max,layer);
        if (check)
        {
            transform.localScale = new Vector3(2, 2, 2);
            anim.Play("Attack");
        }
        else if (check2)
        {
            transform.localScale = new Vector3(-2, 2, 2);
            anim.Play("Attack");
        }
        else
            anim.Play("Idle");
    }
    public void Shooti()
    {
        Audio.Play();
        GameObject gg=poo.Getpool();
        gg.SetActive(true);
        gg.TryGetComponent(out BulletEnemy bu);
        bu.transform.position = a.transform.position;
        bu.SetTran(aa);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(b.transform.position,b.transform.position+Vector3.left*Max);
        Gizmos.DrawLine(b.transform.position,b.transform.position+Vector3.right*Max);
    }
}
