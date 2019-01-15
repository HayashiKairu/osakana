using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respongeta : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        		
	}
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "pleyer")
        {
             transform.position +=new Vector3(0, 0.015f,0);
            
            
        }

    }
}
