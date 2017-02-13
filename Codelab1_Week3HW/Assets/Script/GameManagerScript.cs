using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    private static int score;
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

    public Text scoreAmount;
    public static GameManagerScript instance;

	// Use this for initialization
	void Start () {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            instance.scoreAmount = GameObject.Find("Score").GetComponent<Text>();
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {

        scoreAmount.text = "" + GameManagerScript.instance.Score;
		
	}
}
