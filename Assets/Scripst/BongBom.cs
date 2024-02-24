using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongBom : MonoBehaviour
{
    Rigidbody2D rd;
     float move=10;
     float i;
    float count;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rd.velocity=new Vector2(i,rd.velocity.y)*move;
    }
    public void Setvector(float a)
    {
        i = a;
    }
    private void Update()
    {
        count += Time.deltaTime;
        if (count > 6)
        {
            transform.gameObject.SetActive(false);
            count = 0;
        }
    }
}
