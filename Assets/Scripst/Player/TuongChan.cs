using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuongChan : MonoBehaviour
{
    [Range(1, 20)]
    [SerializeField] float Khoangcach;
    public LayerMask Player;
    public GameObject Prefabs;
    float Dem;
    [SerializeField] Transform A;
    [SerializeField] Transform Direct;
    Vector2 HuongSkill;
    [SerializeField] float HuongLocal;
    [SerializeField] Transform SPhearlocal;
    private void Awake()
    {
     
    }
    private void Start()
    {
        transform.localScale=new Vector3(PlayerControler.instance.transform.localScale.x*HuongLocal,1,1);
    }
    void Update()
    {
        HuongSkill = Direct.position - transform.position;
        Collider2D[] a = Physics2D.OverlapCircleAll(SPhearlocal.position, Khoangcach, Player);
        if(a != null)
        {
            for(int i=0; i<a.Length; i++)
            {
                Collider2D collider = a[0];
                if(collider != null)
                {
                    collider.isTrigger = false;
                }
            }
        }
        Dem += Time.deltaTime;
        if (Dem > 0.5)
        {
            Shootfire();
            Dem = 0;
        }
    }
    public void Shootfire()
    {
        GameObject copy = Instantiate(Prefabs,A.position, Quaternion.identity);
        copy.TryGetComponent(out MoveSkill skill);
        skill.transform.localScale = transform.localScale;
        skill.transform.position=A.position;
        skill.SetH(HuongSkill);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(SPhearlocal.position, Khoangcach);
    }
}
