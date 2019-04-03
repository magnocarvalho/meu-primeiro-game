using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float velocidade;
    private float altura;
    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;
        velocidade = 5;
        rbd = this.GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0,-1*velocidade);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("CRASH!!!!");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -altura-1)
            Destroy(this.gameObject);
    }
}
