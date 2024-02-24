using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    Vector2 Targetpoit;
    public Transform A;
    public Transform B;
    [SerializeField] float Speed;
    void Start()
    {
        Targetpoit=B.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, B.position) <= 0.1f)
        {
            Targetpoit=A.position;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Vector3.Distance(transform.position, A.position) <= 0.1f)
        {
            Targetpoit=B.position;
            transform.localScale = new Vector3(1, 1, 1);
        }
        transform.position = Vector3.MoveTowards(transform.position, Targetpoit, Speed*Time.deltaTime);
    }
}
