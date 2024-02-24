using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBossAttack : MonoBehaviour
{
    [SerializeField] GameObject a1;
    [SerializeField] GameObject a2;
    [SerializeField] GameObject a3;
    [SerializeField] GameObject b1;
    [SerializeField] GameObject b2;
    [SerializeField] GameObject b3;
    [SerializeField] GameObject b4;
    [SerializeField] GameObject b5;
    public void AddCollisionAtack1()
    {
        a1.SetActive(true);
       
    }
    public void RemoveCollisionAtack1()
    {
        a1.SetActive(false);
       
    }
    public void Adda2()
    {
        a2.SetActive(true);
    }
    public void Removea2()
    {
        a2.SetActive(false);
    } 
    public void Adda3()
    {
        a3.SetActive(true);
    }
    public void Removea3()
    {
        a3.SetActive(false);
    }
    public void AddCollisionAtack2()
    {
        b1.SetActive(true);
        b2.SetActive(true);
    }
    public void RemoveCollisionAtack2()
    {
        b1.SetActive(false);
        b2.SetActive(false);
    }
    public void Add2CollisionAtack2()
    {
        b3.SetActive(true);
    }
    public void Remove2CollisionAtack2()
    {
        b3.SetActive(false);
    }
    public void Add3CollisionAtack2()
    {
        b4.SetActive(true);
        b5.SetActive(true);
    }
    public void Remove3CollisionAtack2()
    {
        b4.SetActive(false);
        b5.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("BossX");
        }
    }
}
