using System.Collections;
using UnityEngine;

public class Opiskelu : MonoBehaviour
{
    private float maxHealth;
    private float damageAmount;
    private float potionHealAmount;
    //serializeFieldillä näkee mukavasti unityssa realtime valuet
    [SerializeField] private int potionAmount; //määrä ei voi olla puolikas ja tuskin tarvitsee monimutkasta matikkaa ni laitetaan int
    [SerializeField] private float currentHealth;

    void Start()
    {
        maxHealth = 100f;
        currentHealth = 100f;
        damageAmount = 50f;

        potionHealAmount = 30f;
        potionAmount = 2;

        //callattais käytännössä muualla vaikka collision triggerissä
        DoDommage(damageAmount);
    }

    //if hirviö method
    void DoDommage(float kakkaKikkare)
    {
        //vähentää kakkaKikkareen verran hp currentHealthista
        currentHealth = currentHealth - kakkaKikkare;

        //AUTOPOT Jos hp 0 tai alle, käyttää potionin automaattisesti
        if (currentHealth <= 0 && potionAmount > 0)
        {
            //heal for potionHealAmount and reduce one potion
            currentHealth += potionHealAmount;
            potionAmount--;
            //jos potionin jälkeen vieläkin 0 tai alle, tee uudestaan doDommage 0 damagella
            if (currentHealth <= 0)
            {
                DoDommage(0);
            }
        }
        //jos hp 0 tai alle ja potionmäärä 0 tai alle
        else if (currentHealth <= 0 && potionAmount <= 0)
        {
            //you died
            Debug.Log("dead");
        }
        //jos hp menee yli maxHealth aseta currentiksi maxHealth
        else if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        //muuten eli tässä tapauksessa silloin, kun current health yli 0
        else
        {
            Debug.Log("still alive :)");
        }
    }
}