using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ntcCtlr : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject maldoso;
    void Start()
    {
        Vector2 posicao = new Vector2(0, 6);
        Instantiate(maldoso, posicao, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
