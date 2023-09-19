using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public int miVariable = 1;
    public float miVariable1 = 1.0f;

    public GameObject GameObject;


   



    private void Start()
    {
        float variable1 = 10.5f;
        float variable2 = 3.75f;

        float resultadoFloat = variable1 / variable2;
        int resultadoEntero = (int)resultadoFloat;

        Debug.Log("El resultado en float es:" + resultadoFloat);
        Debug.Log("El resultado en entero (con casting explicito) es:" + resultadoEntero);


    }
    // Update is called once per frame
    void Update()
    {
        miVariable *= 2;
        Debug.Log("El valor actual de la variable es: " + miVariable);
    }

    private void FixedUpdate()
    {
        miVariable1 *= 1.5f;
        Debug.Log("El valor actual de la variable es: " + miVariable1);

        int numero = 8;
        if (numero % 2 == 0)
        {
            Debug.Log(numero + "es un numero par.");
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else 
        {
            Debug.Log(numero + "es un numero impar.");
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }

    }
}
