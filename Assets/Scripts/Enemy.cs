using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float enemySpeed;
    int enemyPoints;

    void enemyMovement()
    {
        enemySpeed += 0.0001f;
        transform.Translate(enemySpeed, 0, 0);
    }

    //private void ontriggerenter2d(collider2d collision)
    //{
    //    if (collision.comparetag("player"))
    //    {
    //        debug.log("hit!");
    //    }
    //}

 
    //private void OnCollisionEnter2D(Collision2D col)
    //{
    //    EnemyHit();
    //    Debug.Log(enemyPoints);
    //}

    void EnemyHit()
    {
        enemyPoints++; // sama kuin: enemyPoints += 1;

    }

    void Start()
    {
        enemySpeed = 0f;
        enemyPoints = 0;
    }

    void Update()
    {
        enemyMovement();
    }
}
