using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadMovimiento;
    public Transform[] puntosMovimiento;
    public float distanciaMinima;
    private int siguientePaso;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePaso].position, velocidadMovimiento * Time.deltaTime);

        if (Vector2.Distance(transform.position, puntosMovimiento[siguientePaso].position) < distanciaMinima)
        {
            siguientePaso++;
            if(siguientePaso >= puntosMovimiento.Length)
            {
                siguientePaso = 0;
            }
        }
    }
}
