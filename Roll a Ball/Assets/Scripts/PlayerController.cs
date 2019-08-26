using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float speed;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       
    }

    private void FixedUpdate()
    {
        float dirVertical = Input.GetAxis("Vertical") * speed;
        float dirHorizontal = Input.GetAxis("Horizontal") * speed;

        Vector3 movement = new Vector3(dirHorizontal, 0.0f, dirVertical);

        player.AddForce(movement, ForceMode.Force);
    }

}
