using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion : MonoBehaviour
{
    public int Score = 0;

    private void OnMouseDown()
    {
        if(tag == "Enemy")
        {
            Destroy(gameObject);
            ScoreUI.score += Score;
            
        }

        if (tag == "Ally")
        {
            Destroy(gameObject);
        }
    }
    
}
