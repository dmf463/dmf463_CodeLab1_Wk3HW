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
    public List<GameObject> trashballs;
    public GameObject prefab;
    public GameObject[] spawnpoints;

	// Use this for initialization
	void Start () {

        spawnpoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        if (instance == null)
        {
            GameObject newTrash1 = Instantiate(prefab, spawnpoints[0].GetComponent<Transform>().position, Quaternion.identity);
            GameObject newTrash2 = Instantiate(prefab, spawnpoints[1].GetComponent<Transform>().position, Quaternion.identity);
            GameObject newTrash3 = Instantiate(prefab, spawnpoints[2].GetComponent<Transform>().position, Quaternion.identity);
            GameObject newTrash4 = Instantiate(prefab, spawnpoints[3].GetComponent<Transform>().position, Quaternion.identity);
            GameObject newTrash5 = Instantiate(prefab, spawnpoints[4].GetComponent<Transform>().position, Quaternion.identity);
            GameObject newTrash6 = Instantiate(prefab, spawnpoints[5].GetComponent<Transform>().position, Quaternion.identity);
            GameObject newTrash7 = Instantiate(prefab, spawnpoints[6].GetComponent<Transform>().position, Quaternion.identity);
            trashballs = new List<GameObject>();
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            prefab = GameObject.Find("Trash");
            instance.scoreAmount = GameObject.Find("Score").GetComponent<Text>();
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {

        scoreAmount.text = "" + GameManagerScript.instance.Score;

    }

    //public void findTrashPosition(int arrayNumber)
    //{
    //    GameObject[] trash = GameObject.FindGameObjectsWithTag("Trash");
    //    trash[arrayNumber].transform.position = new Vector3(trash[arrayNumber].transform.position.x, trash[arrayNumber].transform.position.y, trash[arrayNumber].transform.position.z);
    //    Debug.Log(trash + "" + trash[arrayNumber].name);
    //    trashballs.Add(trash[arrayNumber]);
    //}

    public void warpNow()
    {
        //findTrashPosition(0);
        //findTrashPosition(1);
        //findTrashPosition(2);

        Scene currentScene = SceneManager.GetActiveScene();

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
