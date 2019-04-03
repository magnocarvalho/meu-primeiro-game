using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    public float velocidade;
    private float largura;
    private float altura;
    public GameObject tiro;
    //Criando uma variável que servirá como referências ao RigidBody do meu objeto de jogo.
    private Rigidbody2D rbd;

    public AudioSource soz;
    
    void Start()
    {
       
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
       
        rbd = GetComponent<Rigidbody2D>();
   
    }

    void Update()
    {
        
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
      
        if (transform.position.x > largura)
            transform.position = new Vector2(-largura,transform.position.y);
        else if(transform.position.x < -largura)
            transform.position = new Vector2(largura, transform.position.y);
        if (transform.position.y > 0 && dirY>0 || transform.position.y < -altura && dirY < 0)
            dirY = 0;

        rbd.velocity = new Vector2(dirX,dirY)*velocidade;

        if (Input.GetKeyDown(KeyCode.Space)) {
            soz.Play();
            Instantiate(tiro, transform.position, Quaternion.identity);
        }
    }
}
