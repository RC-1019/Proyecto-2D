using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "Enemy")
        {
            Debug.Log("Entr� al limite");
            gameObject.SetActive(false);
        }
    }
}
