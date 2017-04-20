using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolas : MonoBehaviour {

    public Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        float xDir = Random.Range(-0.5f, 0.5f);
        float zDir = Random.Range(-0.5f, 0.5f);

        
        Vector3 direction = new Vector3(transform.position.x*xDir, transform.position.y, transform.position.z*zDir);
        //rb.velocity = direction * speed;
        rb.velocity =  -transform.position * speed;
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
