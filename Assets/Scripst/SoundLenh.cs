using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLenh : MonoBehaviour
{
    AudioSource Audio;
    bool c;
     int i=0;
    private void Update()
    {
        if (c&&i<1)
        {
            Audio.Play();
            i++;
        }
    }
    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            c = true;
        }
    }
}
