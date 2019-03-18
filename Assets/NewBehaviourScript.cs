using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidade;
    private float largura;
    // Start is called before the first frame update
    void Start()
    {
        largura = Camera.main.orthographicSize * Camera.main.aspect; 
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(dirX, dirY) * Time.deltaTime * velocidade);

        if(transform.position.x > largura)
        {
            transform.position = new Vector2(-largura, transform.position.y);
        }
        else if(transform.position.x < -largura)
        {
            transform.position = new Vector2(largura, transform.position.y);
        }
    }
}
