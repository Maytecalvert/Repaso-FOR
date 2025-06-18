using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroArrays : MonoBehaviour
{
    public int[] edades;

    // Start is called before the first frame update
    void Start()
    {
        //escribe el primer elemento del array
        Debug.Log(edades[0]);

        //escribir cuantos elementos tiene el array
        Debug.Log("El array tiene " + edades.Length + " elementos");

        //escribir el ultimo elemento del array
        Debug.Log(edades[edades.Length -1]);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
