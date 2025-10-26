using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    public int number1 = 0;
    public int number2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (number1 == number2)
            Debug.Log("I numeri sono uguali");

        if (number1 > number2)
            Debug.Log("Il maggiore e'" + number1);
        else
            Debug.Log("il maggiore e'" + number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
