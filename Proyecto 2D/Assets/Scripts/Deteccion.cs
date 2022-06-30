using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion : MonoBehaviour
{
    [Header("Datos puntaje")]
    public int Score = 0;
    public int vidaNemesis = 2;

    [Header("Información sonido")]
    public AudioSource Source;
    public AudioClip[] efectos;

    [Header("Datos de animación")]
    public Animator animacion;

    private void OnMouseDown()
    {
        
        if (tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(efectos[1], gameObject.transform.position);
            animacion.SetBool("Muerte", true);
            Destroy(gameObject, 0.2f);
            ScoreUI.score += Score;            
        }

        if (tag == "Jill")
        {
            AudioSource.PlayClipAtPoint(efectos[0], gameObject.transform.position);
            animacion.SetBool("Muerte", true);
            Destroy(gameObject, 0.2f);
        }

        if (tag == "Carlos")
        {
            AudioSource.PlayClipAtPoint(efectos[0], gameObject.transform.position);
            animacion.SetBool("Muerte", true);
            Destroy(gameObject, 0.2f);
        }

        if (tag == "Nemesis")
        {
           AudioSource.PlayClipAtPoint(efectos[2], gameObject.transform.position);
           animacion.SetBool("Muerte", true);
           Destroy(gameObject, 0.2f);
           ScoreUI.score += Score;
        }
    }
    
}
