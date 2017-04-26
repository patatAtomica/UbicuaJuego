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
        
        float signX = -1*Mathf.Sign(transform.position.x);
        float signZ = -1*Mathf.Sign(transform.position.z);

        float xDir = Random.Range(Mathf.Min(signX, 2*signX), Mathf.Max(signX, 2 * signX));
        float zDir = Random.Range(Mathf.Min(signZ, 2 * signZ), Mathf.Max(signZ, 2 * signZ));
        
        
        Vector3 direction = new Vector3(xDir, 0, zDir);
        //rb.velocity = direction * speed;
        //rb.velocity =  (direction/direction.magnitude) * speed;
        ArrayBolas.listabolas.Add(this);
        rb.AddForce((direction / direction.magnitude) * speed, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
