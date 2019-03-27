using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserosa : MonoBehaviour
{
    private float largura;
    private float altura;
    float raa;
    public GameObject laser;
    void Start()
    {

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

        InvokeRepeating("respaw", 3, 0.5f);
        respaw();

    }
    private void respaw()
    {
        raa = Random.Range(-largura, largura);
        Vector2 posicao = new Vector2(raa, altura + 1);
        Instantiate(laser, posicao, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
