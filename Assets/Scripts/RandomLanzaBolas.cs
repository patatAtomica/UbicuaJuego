using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLanzaBolas : MonoBehaviour {

    public GameObject[] LanzaBolas = new GameObject[4];
	// Use this for initialization
	void Start (){
        InvokeRepeating("SeleccionarLanzador", 2.0f, 1.5f);
    }

    void SeleccionarLanzador()
    {
        var indice = Random.Range(0, 3);
        LanzaBolas[indice].GetComponent<LanzadorBolas>().LanzadorBola();     
    }
   
    // Update is called once per frame
    void Update ()
    {
		
	}
}
