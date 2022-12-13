using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    string word = "Working";
    float energy = 100;
    float position = 10.5f;
    bool canSpeak = false;
    // Start is called before the first frame update
    void Start()
    {
        if (canSpeak == true)
        {

            Debug.Log(word);
            print(energy);
            print(position);
            print(canSpeak);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (energy > 0)
        {
            energy = energy - 0.001f;
            print(energy);
        }
    }
}
