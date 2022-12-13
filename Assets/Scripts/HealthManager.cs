using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager: MonoBehaviour
{
    int playerHealth;
    int minHealth;
    string text;
    string sceneGameOver;

    string gameOverText;



    //[serializefield] gameobject healthbar1;
    //[serializefield] gameobject healthbar2;
    //[serializefield] gameobject healthbar3;
    //[serializefield] gameobject healthbar4;

    [SerializeField] List<GameObject> HealthBarList;


    int numberOne = 1;
    int numberTwo = 2;

    string UpdateTest()
    {
        //Debug.Log("UpdateTest() works!");
        return "Text!";
        
    }


    int CalculateTwoNumbers(int firstNumber, string successText)
    {
        Debug.Log(successText);
        return firstNumber;

    }

    void HealthBarManager()
    {
        for (int i = 4; i>= 0; i--)
        {
            Debug.Log(i);
        }

        //if(playerHealth == 3)
        //{
        //    Healthbar1.SetActive(false);
        //}
        //if(playerHealth == 2)
        //{
        //    Healthbar2.SetActive(false);    
        //}
        //if(playerHealth == 1)
        //{
        //    Healthbar3.SetActive(false);
        //}
        //if(playerHealth == 0)
        //{
        //    Healthbar4.SetActive(false);
        //}
    }


    string GameOverText()
    {
        if(playerHealth <= minHealth)
        {
            // text = "Game over";
            // sceneGameOver = "GameOver";
            gameOverText = "Game over";

            //disappearingGameObject.SetActive(false);

            //SceneManager.LoadScene(sceneGameOver);
        }

        return gameOverText;

    }



    void OnGUI()
    {
        GUI.contentColor = Color.green;
        GUI.backgroundColor = Color.black;
        GUI.skin.label.fontSize = 20;

        GUI.Label(new Rect(50, 20, 350, 100), "Health " + playerHealth);
        GUI.Label(new Rect(50, 40, 350, 100), "" + gameOverText);
       // GUI.Label(new Rect(50, 60, 350, 100), "" + CalculateTwoNumbers(100, "success!!"));
        //GUI.Label(new Rect(50, 40, 350, 100), GameOverText());
    }

        private void OnCollisionEnter2D(Collision2D objekti)
    {

        if (objekti.gameObject.CompareTag("Enemy") && playerHealth > minHealth) // || jompi kumpi, && kumpikin
        {

            playerHealth--;
            //HealthBarManager();
            Debug.Log("PlayerHealth " + playerHealth);
            
        }
        else
            {
            
            }
    }
    

    void Start()
    {
        //Debug.Log(CalculateTwoNumbers());
        gameOverText = "";
        playerHealth = 4;
        minHealth = 0;
    }


    
    void Update()
    {
        GameOverText();
        UpdateTest();
       
    }
}
