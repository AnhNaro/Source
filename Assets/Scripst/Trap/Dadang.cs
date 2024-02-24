using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dadang : MonoBehaviour
{
     SpriteRenderer spriteRenderer;
    bool cc;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    float Count;
    
    void Update()
    {
       
        if(cc)
        {
            spriteRenderer.color = Color.red;
            Count += Time.deltaTime;
            if(Count > 0.4 )
            {

                fillon();

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cc = true;
        }
    }
    void fillon()
    {
            gameObject.SetActive(false);    
    }
}
