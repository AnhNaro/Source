using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaMove : MonoBehaviour
{
    Rigidbody2D rd;
    [SerializeField] float MoveSpeed;
    [SerializeField] GameObject Player;
    Vector2 Direct;
    [SerializeField] Transform NewFireBall;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource =GetComponent<AudioSource>();
        MoveSpeed = Random.Range(40, 150);
        spriteRenderer.sortingOrder = Random.Range(8, 13);
        rd =GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rd.velocity = Direct * MoveSpeed * Time.deltaTime;
    }
    // Update is called once per frame
    float atime;
    void Update()
    {
        atime += Time.deltaTime;
        Direct=Player.transform.position-NewFireBall.transform.position;
        Direct.Normalize();
        if (atime > 6)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            audioSource.Play();
        }
    }
}
