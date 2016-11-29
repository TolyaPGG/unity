using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    public WheelCollider[] frontCols;
    public Transform[] dataFront;
    public WheelCollider[] backCol;
    public Transform[] dataBack;
    public Transform centerOfMass;

    public float maxSpeed = 30f;
    private float sideSpeed = 50f;
    public float breakSpeed = 100f;

    

    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass.localPosition;
       
    }

    void Update()
    {
       
        float vAxis = Input.GetAxis("Vertical");
        float hAxis = Input.GetAxis("Horizontal");
        bool brakeButton = Input.GetButton("Jump");
        

        
        backCol[0].motorTorque = -vAxis * maxSpeed;
        backCol[1].motorTorque = -vAxis * maxSpeed;
        

        
        if (brakeButton)
        {
            backCol[0].brakeTorque = Mathf.Abs(backCol[0].motorTorque) * breakSpeed;
            backCol[1].brakeTorque = Mathf.Abs(backCol[1].motorTorque) * breakSpeed;
        }
        else
        {
            backCol[0].brakeTorque = 0;
            backCol[1].brakeTorque = 0;
        }
        

        
        frontCols[0].steerAngle = hAxis * sideSpeed;
        frontCols[1].steerAngle = hAxis * sideSpeed;



        dataFront[0].Rotate(frontCols[0].rpm * Time.deltaTime * 5, 0, 0);
        dataFront[1].Rotate(frontCols[1].rpm * Time.deltaTime * 5, 0, 0);
        dataBack[0].Rotate(backCol[0].rpm * Time.deltaTime * 5, 0, 0);
        dataBack[1].Rotate(backCol[1].rpm * Time.deltaTime * 5, 0, 0);
        dataFront[0].localEulerAngles = new Vector3(dataFront[0].localEulerAngles.x, hAxis * sideSpeed, dataFront[0].localEulerAngles.z);
        dataFront[1].localEulerAngles = new Vector3(dataFront[1].localEulerAngles.x, hAxis * sideSpeed, dataFront[1].localEulerAngles.z);

        WheelHit hit;
        if (backCol[0].GetGroundHit(out hit))
        {
            float vol = (Mathf.Abs(hit.sidewaysSlip) > .25f)?hit.sidewaysSlip*10 : 0;
            
        }

    }
}