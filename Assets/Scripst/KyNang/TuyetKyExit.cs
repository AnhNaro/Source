using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuyetKyExit : MonoBehaviour
{
    float Acout;
    [SerializeField] float TimeExit;
    Rigidbody2D rd;
    float ab;
    void Start()
    {
        rd=GetComponent<Rigidbody2D>();
        ab = PlayerControler.instance.transform.localScale.x;
    }
    private void FixedUpdate()
    {
        rd.velocity = new Vector2(ab,rd.velocity.y) * 500*Time.deltaTime;
    }
    void Update()
    {
        Acout += Time.deltaTime;
        if(Acout > TimeExit)
        {
            gameObject.SetActive(false);   
            Acout = 0;
        }
    }
}
