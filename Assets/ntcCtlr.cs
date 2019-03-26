using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ntcCtlr : MonoBehaviour
{
    // Start is called before the first frame update
    private float largura;
    private float altura;
    float raa;
    public GameObject maldoso;
    void Start()
    {

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

        InvokeRepeating("respaw", 3, 0.3f);
        respaw();
        
    }
    private void respaw()
    {
        raa = Random.Range(-largura, largura);
        Vector2 posicao = new Vector2(raa, altura + 1);
        Instantiate(maldoso, posicao, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
