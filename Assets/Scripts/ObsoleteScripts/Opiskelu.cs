using System.Collections;
using UnityEngine;

public class Opiskelu : MonoBehaviour
{
    private float maxHealth;
    private float damageAmount;
    private float potionHealAmount;
    //serializeFieldill� n�kee mukavasti unityssa realtime valuet
    [SerializeField] private int potionAmount; //m��r� ei voi olla puolikas ja tuskin tarvitsee monimutkasta matikkaa ni laitetaan int
    [SerializeField] private float currentHealth;

    void Start()
    {
        maxHealth = 100f;
        currentHealth = 100f;
        damageAmount = 50f;

        potionHealAmount = 30f;
        potionAmount = 2;

        //callattais k�yt�nn�ss� muualla vaikka collision triggeriss�
        DoDommage(damageAmount);
    }

    //if hirvi� method
    void DoDommage(float kakkaKikkare)
    {
        //v�hent�� kakkaKikkareen verran hp currentHealthista
        currentHealth = currentHealth - kakkaKikkare;

        //AUTOPOT Jos hp 0 tai alle, k�ytt�� potionin automaattisesti
        if (currentHealth <= 0 && potionAmount > 0)
        {
            //heal for potionHealAmount and reduce one potion
            currentHealth += potionHealAmount;
            potionAmount--;
            //jos potionin j�lkeen viel�kin 0 tai alle, tee uudestaan doDommage 0 damagella
            if (currentHealth <= 0)
            {
                DoDommage(0);
            }
        }
        //jos hp 0 tai alle ja potionm��r� 0 tai alle
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
        //muuten eli t�ss� tapauksessa silloin, kun current health yli 0
        else
        {
            Debug.Log("still alive :)");
        }
    }
}