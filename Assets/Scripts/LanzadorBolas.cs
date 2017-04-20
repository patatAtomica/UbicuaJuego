using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzadorBolas : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void LanzadorBola ()
    {    
                //En lalinea de codigo siguiente..//
                //hacer que salgan bolas random de los lanza bolas..//
                //no entre una PosX y una PosY.//
                Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
                Instantiate (hazard, spawnPosition, Quaternion.identity);       
      
	}
}
