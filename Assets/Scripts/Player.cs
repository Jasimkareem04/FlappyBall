using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right* Time.deltaTime * 500, ForceMode.Force);

       if(Input.GetKeyDown(KeyCode.Space))
       {
         GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
       }
       
    }
} 
