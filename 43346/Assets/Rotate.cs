using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{


    
  
  
    public Transform centerOfMass;

    public float maxSpeed = 30f;
  



    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass.localPosition;

    }

    void Update()
    {

        centerOfMass.Rotate(0, maxSpeed, 0);
       
      

    
    }
}