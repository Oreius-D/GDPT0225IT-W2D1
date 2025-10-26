using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int startingNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        int primoPrecedente = --startingNumber;
        Debug.Log("Primo numero precedente: " + primoPrecedente);
        int secondoPrecedente = --primoPrecedente;
        Debug.Log("Secondo numero precedente: " + secondoPrecedente);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
