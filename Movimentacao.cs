using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    Vector3 posicao;
    // Start is called before the first frame update
    void Start()
    {
        posicao = new Vector3(1.0f, 2.0f, 1.5f);
        transform.position = posicao;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0))
        {
            if (transform.position.y <= 9)
            { 
              posicao.y = 0.05f;
              posicao.x = 0.0f;
              posicao.z = 0.0f;
              transform.Translate(posicao);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.z <= 9)
            {
                 posicao.y = 0.0f;
                 posicao.x = 0.0f;
                 posicao.z = 0.05f;
                 transform.Translate(posicao);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.z >= -9)
            {
                posicao.y = 0.0f;
                posicao.x = 0.0f;
                posicao.z = -0.05f;
                transform.Translate(posicao);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.position.x <= 9)
            {
               posicao.y = 0.0f;
               posicao.x = 0.05f;
               posicao.z = 0.0f;
               transform.Translate(posicao);
            }
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x >= -9)
            {
                posicao.y = 0.0f;
                posicao.x = -0.05f;
                posicao.z = 0.0f;
                transform.Translate(posicao);
            }
            
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Destroy(this.gameObject);
        }
    }
}
