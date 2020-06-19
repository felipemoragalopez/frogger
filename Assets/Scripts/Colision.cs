using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public GameObject nave1;
    public GameObject nave2;
    public GameObject otrolado;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == nave1)
        {
            Debug.Log("Auch!");
        }
        if (collision.gameObject == otrolado)
        {
            Debug.Log("Lo consegui");
        }
        if (collision.gameObject == nave2)
        {
            Debug.Log("Auch!");
        }
    }
}
