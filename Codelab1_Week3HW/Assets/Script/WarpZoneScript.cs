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
            if (currentScene.name == "Scene1")
            {
                SceneManager.LoadScene("AlternateDimension");
            }
            if (currentScene.name == "AlternateDimension")
            {
                SceneManager.LoadScene("Scene1");
            }
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
