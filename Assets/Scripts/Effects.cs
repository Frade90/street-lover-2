using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public GameObject BarrellEffect;

    private void OnCollisionEnter2D(Collision2D barrell)
    {
        if (barrell.gameObject.CompareTag("PaleAleHealth"))
        {
        BarrellEffect.SetActive(true);
        }
    }


    private void OnCollisionExit2D(Collision2D barrell)
    {
        if (barrell.gameObject.CompareTag("PaleAleHealth"))
        {
            BarrellEffect.SetActive(false);
        }
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
