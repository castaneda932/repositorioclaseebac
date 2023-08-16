using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_ColorRandom : MonoBehaviour
{
    public GameObject prefabcube;
    public List<GameObject> listadecubos;
    public int numcubos = 0;

       



    // Start is called before the first frame update
    void Start()
    {
        listadecubos = new List<GameObject>();
        GameObject gameObject = Instantiate(prefabcube);
        
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
