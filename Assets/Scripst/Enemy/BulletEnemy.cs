using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    Rigidbody2D rb;
   [SerializeField] float SpeedBullet;
    Vector2 direc;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.velocity = direc * SpeedBullet;
    }
    public void SetTran(Vector2 a)
    {
        direc=a;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
          transform.gameObject.SetActive(false);
        }
        if (collision.CompareTag("Ground"))
        {
            transform.gameObject.SetActive(false);
        }
    }
}
