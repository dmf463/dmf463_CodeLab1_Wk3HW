using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

    private int score;
    public int Score
    {
        get
        {
            Debug.Log("Score is Being Accessed From Here");
            return score;
        }
        set
        {
            score = value;
            Debug.Log("Score was set to: " + score);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
