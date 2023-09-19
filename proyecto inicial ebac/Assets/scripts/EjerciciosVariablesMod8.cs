using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public int miVariable = 1;
    public float miVariable1 = 1.0f;

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

    }
}
