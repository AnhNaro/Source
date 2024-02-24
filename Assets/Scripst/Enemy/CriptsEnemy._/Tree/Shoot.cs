using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Shoot : MonoBehaviour
{
    [SerializeField] PoolingBulet pol;
    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] Transform Shot;
    Vector2 Direct;
    AudioSource Audio;
    private void Start()
    {
        Audio = GetComponent<AudioSource>();    
    }
    private void Update()
    {
        Direct = b.position - a.position;
    }
    public void Shooitree()
    {
        Audio.Play();   
        GameObject am = pol.Getpool();
        am.gameObject.SetActive(true);
        am.TryGetComponent(out BulletEnemy em);
        em.transform.localScale = transform.localScale;
        em.transform.position = Shot.transform.position;
        em.SetTran(Direct);
    }
}
