﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class PlayOnCollide : MonoBehaviour
{
    AudioSource audioData;
    public GameObject Ball;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nonplayer")
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
