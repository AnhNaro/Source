using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSkill : MonoBehaviour
{
    Rigidbody2D rd;
    [SerializeField] float Speed;
    Vector2 Huong;
    public float delayexit;
     float Dem;
    public GameObject Fx;
    public Transform fxno;
  
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
      
        rd.velocity = Huong* Speed * Time.deltaTime;
      
    }
    void Update()
    {
       
        Dem += Time.deltaTime;
        if (Dem>delayexit)
        {
            gameObject.SetActive(false);
            Dem = 0;
        }
       
    }
    public void SetH(Vector2 a)
    {
        Huong = a;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Fxno();
        }
        if (collision.CompareTag("Boss"))
        {
            Fxno();
        }
    }
    public void Fxno()
    {
        GameObject G = Instantiate(Fx, fxno.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
