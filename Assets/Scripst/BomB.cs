using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomB : MonoBehaviour
{
     float localx;
    public float Dem;
    public float Dem2;
    float local2;
    Rigidbody2D rb;
    void Start()
    {
        transform.localScale=PlayerControler.instance.transform.localScale;
        localx = PlayerControler.instance.transform.localScale.x;
        local2 = localx;
        rb=GetComponent<Rigidbody2D>(); rb.isKinematic = true;

    }
    private void Update()
    {
        Dem2 += Time.deltaTime;
        Dem += Time.deltaTime;
        if (Dem > 1)
        {
            SpawCaubom();
            Dem = 0;
        }
        if (Dem2> 8)
        {
            gameObject.SetActive(false);
            Dem2 = 0;
        }
    }
    public void SpawCaubom()
    {

        GameObject S =Player.ChangerMessenger.Poolingplayer.Getpool();
        S.gameObject.SetActive(true);
        S.TryGetComponent(out BongBom bom);
        bom.transform.localScale=transform.localScale;
        bom.transform.position = transform.position;
        bom.Setvector(local2);
    }
}
