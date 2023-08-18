using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_ColorRandom : MonoBehaviour
{
    public GameObject prefabcube;
    
    public int numcubos = 0;

       



    // Start is called before the first frame update
    void Start()
    {
        
        GameObject gameObject = Instantiate(prefabcube);
        prefabcube.AddComponent<MeshRenderer>();
        var MeshRendererMaterial = prefabcube.GetComponent<MeshRenderer>().material;
        MeshRendererMaterial.color = Color.black;



       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
