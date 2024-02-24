using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastong : MonoBehaviour
{
    public PoolingBulet poo;
    [SerializeField] EnemyControlerGame enemy;
    Animator anim;
    [SerializeField] bool CheckPlayer;
    public LayerMask play;
    [Range(1f,30f)]
    [SerializeField] float Max;
    [SerializeField] Transform B1;
    [SerializeField] Transform B2;
    float a = 0;
    AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio=GetComponent<AudioSource>();
        anim=GetComponent<Animator>();
        anim.Play("Idle");
    }

    // Update is called once per frame
    
    void Update()
    {
        CheckPlayer = Physics2D.Raycast(transform.position, Vector2.down, Max, play);
       bool CheckPlayer2 = Physics2D.Raycast(B1.transform.position, Vector2.down, Max, play);
       bool CheckPlayer3 = Physics2D.Raycast(B2.transform.position, Vector2.down, Max, play);
        if (CheckPlayer||CheckPlayer2||CheckPlayer3)
        {
           
           anim.Play("Attack");
           
        }
        if (a == 8)
        {
            enemy.atribuidHandDel.CurrunHp /= 2;
        }
        if (a == 13)
        {
            enemy.atribuidHandDel.CurrunHp = 0;
        }
      
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position+Vector3.down*Max);
        Gizmos.DrawLine(B1.transform.position, B1.transform.position+Vector3.down*Max);
        Gizmos.DrawLine(B2.transform.position, B2.transform.position+Vector3.down*Max);
    }
    public void Shoot()
    {
        a++;
        Audio.Play();
        GameObject Go=poo.Getpool();
        Go.SetActive(true);
        Go.TryGetComponent(out BulletEnemy bu);
        bu.transform.position = transform.position;
        bu.SetTran(Vector2.down);
    }
}
