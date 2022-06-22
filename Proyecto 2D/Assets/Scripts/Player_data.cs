using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_data : MonoBehaviour
{
    [Header("Datos del jugador")]
    public int puntaje;
    public int vidas = 3;
    private float limite = -6.2f;

    private void Update()
    {
        if (transform.position.y < limite)
        {
            Destroy(gameObject);
            puntaje++;
            vidas--;
        }
    }

}
