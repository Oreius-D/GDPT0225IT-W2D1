using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (numero % 2 == 0)
            Debug.Log("Il numero e' pari");
        else
            Debug.Log("Il numero e' dispari");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
