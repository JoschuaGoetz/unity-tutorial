using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float speed;
    private int count;
    public Text[] infoLabels;
    public Text winLabel;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
        count = 0;
        winLabel.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(!other.gameObject.activeSelf);
            count++;

            updateLabels();

            if (count == 12)
                winLabel.text = "Congratulation you win !";
        }
    }

    private void FixedUpdate()
    {
        float dirVertical = Input.GetAxis("Vertical") * speed;
        float dirHorizontal = Input.GetAxis("Horizontal") * speed;

        Vector3 movement = new Vector3(dirHorizontal, 0.0f, dirVertical);

        player.AddForce(movement, ForceMode.Force);
    }

    private void updateLabels()
    {
        Array.ForEach(infoLabels, label => label.text = label.text.Substring(0, label.text.IndexOf(":") + 1) + " " + count.ToString());
    }

}
