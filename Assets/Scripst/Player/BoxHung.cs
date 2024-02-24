using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHung : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            endzo();
        }
    }
    public void endzo()
    {
        Manager.Instance.Loss();
    }
   
}
