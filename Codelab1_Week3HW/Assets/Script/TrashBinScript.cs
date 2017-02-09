using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Trash")
        {
            Destroy(other.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
