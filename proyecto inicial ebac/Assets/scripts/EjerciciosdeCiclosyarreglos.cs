using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            int[] arr1 = new int[10]; 
            int[] arr2 = new int[10]; 
            int[] arr3 = new int[10]; 

            
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = Random.Range(1, 25); 
                arr2[i] = Random.Range(1, 25);
            }

            
            for (int i = 0; i < 10; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }

            
            Debug.Log("arr1: " + string.Join(", ", arr1));
            Debug.Log("arr2: " + string.Join(", ", arr2));
            Debug.Log("arr3: " + string.Join(", ", arr3));
        }

        string[] palabras = new string[]
        {
            "Esto", "es", "muy", "complicado", "de", "hacer"
        };

        string oracionCompleta = "";

        // Usando un ciclo foreach para concatenar las palabras
        foreach (string palabra in palabras)
        {
            oracionCompleta += palabra + " ";
        }

        // Imprimir la oración completa en la consola
        Debug.Log(oracionCompleta);






    }
}
