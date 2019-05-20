using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNPCController : MonoBehaviour
{
    public GameObject inimigo;
    private float largura;
    private float altura;

    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

        InvokeRepeating("respawn",0,1);
    
    }

    private void respawn()
    {
        float posX = Random.Range(-largura, largura);
        Vector2 posicao = new Vector2(posX, altura + 1);
        Instantiate(inimigo, posicao, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
