 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSOI : MonoBehaviour
{
    Rigidbody2D rd;
    [SerializeField] float MoveSoi;
    public Vector2 Limit;
    // Start is called before the first frame update
    void Start()
    {
        rd=GetComponent<Rigidbody2D>();
        transform.position= new Vector2(Limit.x,transform.position.y);
    }
    private void FixedUpdate()
    {
        if (transform.position.x >= Limit.x)
        {
            rd.velocity=Vector2.left*MoveSoi;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(transform.position.x<=Limit.y)
        {
            rd.velocity = Vector2.right * MoveSoi;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
