using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform A, B;
    [SerializeField] float Speed;
    Vector2 Target;
    // Start is called before the first frame update
    void Start()
    {
      transform.position = A.position;  
        Target=B.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, B.position) < 0.1f)
        {
            Target=A.position;
        }
        if (Vector2.Distance(transform.position, A.position) < 0.1f)
        {
            Target=B.position;  
        }
        transform.position=Vector2.MoveTowards(transform.position, Target, Speed*Time.deltaTime);  
    }
  
}
