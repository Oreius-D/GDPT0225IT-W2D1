using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio8 : MonoBehaviour
{
    public int voto = 0;

    // Start is called before the first frame update
    void Start()
    {
        switch (voto)
        {
            case 10:
                Debug.Log("A+");
                break;
            case 9:
                Debug.Log("A");
                break;
            case 8:
                Debug.Log("B");
                break;
            case 7:
                Debug.Log("B");
                break;
            case 6:
                Debug.Log("C");
                break;
            case 5:
                Debug.Log("D");
                break;
            default:
                Debug.Log("F");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
