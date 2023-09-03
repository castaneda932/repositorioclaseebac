
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo1 : MonoBehaviour
{
    public GameObject GameObject;

    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }

    bool variable1;
    bool variable2;
    bool variable3;
    
   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(variable1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        
    }
}
