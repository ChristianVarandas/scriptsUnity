using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboMover : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 movimentacao;
    void Start()
    {
        movimentacao = new Vector3(-3.0f, 7.8f, 4.1f);
        transform.position = movimentacao;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            movimentacao.y = 6.0f;
            movimentacao.x = 0.0f;
            movimentacao.z = 0.0f;
            transform.Translate(movimentacao);
        }
    }
}
