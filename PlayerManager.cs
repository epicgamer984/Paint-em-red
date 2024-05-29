  using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float horizontalInput; 
    public float speed = 10.0f;
    public float xRange = 10;
     public GameObject projectilePrefab;
     public float pos;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

       
        if (Input.GetKeyDown(KeyCode.E)) 
        {
                Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
         
    }
}
