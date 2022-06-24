using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Limite : MonoBehaviour
{
    public GameObject[] Vida;
    public int life = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            life--;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Ally")
        {
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        if(life < 1)
        {
            Destroy(Vida[0].gameObject);
        }
        else if(life < 2)
        {
            Destroy(Vida[1].gameObject);
        }
        else if(life < 3)
        {
            Destroy(Vida[2].gameObject);
        }
    }
}
