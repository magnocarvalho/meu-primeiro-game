﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navemal : MonoBehaviour
{
    private Rigidbody2D mal;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 6;
        mal = this.GetComponent<Rigidbody2D>();
        mal.velocity = new Vector2(0, -1*velocidade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
