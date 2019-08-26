using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    System.Random r = new System.Random();

	void Update ()
    {

        int x = r.Next(0, 2);
        int y = r.Next(0, 2);
        int z = r.Next(0, 2);
       
        transform.Rotate(new Vector3(45 * x, 45 * y, 45 * z) * Time.deltaTime, Space.Self);
	}
}
