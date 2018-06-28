using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
    public GameObject Car;
     float CarX;
     float CarY;
     float CarZ;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        CarX = Car.transform.eulerAngles.x;
        CarY = Car.transform.eulerAngles.y;
        CarZ = Car.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
	}
}
