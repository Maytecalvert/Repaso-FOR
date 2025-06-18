using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    // Start is called before the first frame update

    public int num1;
    public int num2; 

    void Start()
    {
        // imprime numeros del 0 al 4

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        // multiplos de 2 hasta el 40 inclusive

        for (int i = 2; i <= 40; i += 2)
        {
            Debug.Log(i);
        }


        // multiplos de un entero ingresado por inspector
        // hasta otro numero ingresado por inspecto NO INCLUSIVE

        for (int i = num1; i < num2; i += num1)
        {
            Debug.Log(i);
        }

        // escribir en consola los numeros entre 100 y 10 inclusive

        for (int i = 100; i >= 10; i--)
        {
            if (i == 33)
            {
                continue; //sigue con el resto de las acciones del loop
            }
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
