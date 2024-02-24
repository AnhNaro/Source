
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSKele : MonoBehaviour
{
    public PoolingBulet PoSke;
    public Vector2 GroundSpawske;
    public Transform Chieucaospaw;
    public bool GroundCheck;
    void Start()
    {
       
    }
     float oi;
    float yy;
    float livetime;
    // Update is called once per frame
    void Update()
    {
        yy += Time.deltaTime;
        oi=Random.Range(GroundSpawske.x, GroundSpawske.y);
        if (GroundCheck)
        {
            livetime += Time.deltaTime;
            if (yy >3)
            {
                SpawSke();
                yy = 0;
            }
            if (livetime >10)
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void SpawSke()
    {
        
        GameObject go = PoSke.Getpool();
        go.SetActive(true);
        go.transform.position=new Vector2(oi,Chieucaospaw.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GroundCheck= true;
        }
    }
}
