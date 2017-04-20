using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour {

    private Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        rb.AddForce(movement * speed);
    }
}
