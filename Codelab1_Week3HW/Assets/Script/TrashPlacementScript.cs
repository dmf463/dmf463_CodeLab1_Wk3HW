using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPlacementScript : MonoBehaviour {

    public static TrashPlacementScript instance;

	// Use this for initialization
	void Start () {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
