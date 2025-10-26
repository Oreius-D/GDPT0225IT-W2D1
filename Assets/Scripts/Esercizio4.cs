using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int startingNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        int primoSuccessivo = ++startingNumber;
        Debug.Log("Primo numero successivo: " +  primoSuccessivo);
        int secondoSuccessivo = ++primoSuccessivo;
        Debug.Log("Secondo numero successivo: " + secondoSuccessivo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
