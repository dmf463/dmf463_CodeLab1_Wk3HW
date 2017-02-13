using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpZoneScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (other.gameObject.tag == "Player")
        {
            GameManagerScript.instance.warpNow();
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
