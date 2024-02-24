using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraforllow : MonoBehaviour
{
    public Vector2 LimitX;
    public Vector2 LimitY;
    public Transform Player;
    Vector3 RanS;
    [Range(0,6f)]
    [SerializeField] float Smooth;
    Vector3 ai;
    void Start()
    {
        RanS = transform.position - Player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Minit=RanS+Player.position;
        Minit.x=Mathf.Clamp(Minit.x,LimitX.x,LimitX.y);
        Minit.y = Mathf.Clamp(Minit.y, LimitY.x, LimitY.y);
        transform.position=Vector3.SmoothDamp(transform.position, Minit,ref ai,Smooth);
    }
}
