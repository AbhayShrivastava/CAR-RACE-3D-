using UnityEngine;
using System.Collections;

public class CarMovements : MonoBehaviour {
    public float MotorForce, SteerForce, BrakeForce;
    public WheelCollider FR, FL, RL, RR;
   
	// Use this for initialization
	void Start () {

    
        
        
	}
	
	// Update is called once per frame
	void Update () {

     
        Acceleration();
        Steering();
        
      
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Application.Quit();
        }

        
        

        if (Input.GetKey(KeyCode.Space))
        {
            RR.brakeTorque = BrakeForce;
            RL.brakeTorque = BrakeForce;
           
            
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            RR.brakeTorque = 0;
            RL.brakeTorque = 0;
        }
        

        if (Input.GetAxis("Vertical")==0)
        {
            RR.brakeTorque = BrakeForce;
            RL.brakeTorque = BrakeForce;
           
        }
        else 
        {
            RR.brakeTorque = 0;
            RL.brakeTorque = 0;
        }
        }
	



    void Acceleration()
    {
          float v =Input.GetAxis("Vertical")*-MotorForce;
        
        
        RR.motorTorque = v;
        RL.motorTorque = v;
       
    }



    void Steering()
    {
        float h = Input.GetAxis("Horizontal") * SteerForce;


        FL.steerAngle = h;
        FR.steerAngle = h;
       
    }
	}

