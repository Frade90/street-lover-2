using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //int HealthIndexGlobal = 100;
    float SuperPowerUp = 120f;


    [SerializeField] List<GameObject> HealthBarList;
    int HealthBarListIndex = 0;
    int DamagePoint = 1;
    int HealthPoint = 1;

    void ReduceHealth(int AnyGlobalVariable)
    {
        HealthBarList[HealthBarListIndex].SetActive(false);

        if (HealthBarListIndex < 3)
        {
            HealthBarListIndex += DamagePoint;
        }
    }
    void GainHealth(int AnyGlobalVariable)
    {
        
        if (HealthBarListIndex > 0)
        {
            HealthBarListIndex -= AnyGlobalVariable;
        }
        HealthBarList[HealthBarListIndex].SetActive(true);
       // Debug.Log("gain");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Enemy"))
        {
            ReduceHealth(DamagePoint);
        }
        if (collision.gameObject.CompareTag("PaleAleHealth"))
        {
            //Debug.Log("Index is: "+ HealthBarListIndex);
    
            GainHealth(HealthPoint);
        }
        if (collision.gameObject.CompareTag("MegaHealthBarrell"))
        {
          




            for (int HealthBarListIndex = 0; HealthBarListIndex < 4; HealthBarListIndex++)
            {
                HealthBarList[HealthBarListIndex].SetActive(true); 
               
            }

            HealthBarListIndex = 0;
        }
    }
  
void Start()
    {

    }


    void Update()
    {

    }
}
