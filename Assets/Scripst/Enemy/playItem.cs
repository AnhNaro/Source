using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playItem : MonoBehaviour
{
    
    public ParticleSystem ParticleSystem;
    public GameObject Object;
     bool Set;
    private void Awake()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            itemplay();
        }
       
    }
  

    void itemplay()
    {
        Set = true;
        ParticleSystem.Play();
       Object.gameObject.SetActive(false);
    }
    float i;
    private void Update()
    {
        if (Set)
        {
            i += Time.deltaTime;
            if(i > 0.42)
            {
                gameObject.SetActive(false);
                i = 0;
            }
        }

    }

}
