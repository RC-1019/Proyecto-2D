using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion : MonoBehaviour
{
    [Header("Datos puntaje")]
    public int Score = 0;
    public int vidaNemesis = 2;
    public GameObject[] sprites;

    [Header("Información sonido")]
    public AudioSource Source;
    public AudioClip[] efectos;

    private void OnMouseDown()
    {
        GetComponent<CapsuleCollider2D>().enabled = false;
        sprites[0].SetActive(false);
        sprites[1].SetActive(true);
        if (sprites[1]==true)
        {
            Destroy(gameObject, 0.6f);
        }



        if (tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(efectos[1], gameObject.transform.position);
            Destroy(gameObject, 0.2f);
            ScoreUI.score += Score;            
        }

        if (tag == "Jill")
        {
            AudioSource.PlayClipAtPoint(efectos[0], gameObject.transform.position);
            Destroy(gameObject, 0.2f);
        }

        if (tag == "Carlos")
        {
            AudioSource.PlayClipAtPoint(efectos[0], gameObject.transform.position);
        }

        if (tag == "Nemesis")
        {
           AudioSource.PlayClipAtPoint(efectos[2], gameObject.transform.position);
           Destroy(gameObject, 0.2f);
           ScoreUI.score += Score;
           
        }
    }
    
}
