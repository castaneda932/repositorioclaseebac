using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{
    
    public List<int> listaDeNumeros = new List<int>();
    public HashSet<int> numerosRepetidos = new HashSet<int>();
    private static object numero;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            listaDeNumeros.Add(Random.Range(i, 30));
        }
        foreach (var numero in listaDeNumeros)
        {
            Debug.Log(numero);
        }
        listaDeNumeros.Sort();
        foreach (var numero in listaDeNumeros)
        {
            Debug.Log(numero);
        }


    }
    


}
