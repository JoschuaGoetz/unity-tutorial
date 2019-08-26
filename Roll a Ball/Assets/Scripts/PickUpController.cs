using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    System.Random r = new System.Random();

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        int x = r.Next(0, 1);
        int y = r.Next(0, 1);
        int z = r.Next(0, 1);
       

        transform.Rotate(new Vector3(45 * x, 45 * y, 45 * z), Space.Self);
	}
}
