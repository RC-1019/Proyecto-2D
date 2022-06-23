using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Limite : MonoBehaviour
{
    public int puntaje = 100;
    public int puntajeTotal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Ally")
        {
            Destroy(collision.gameObject);
        }
    }
}
