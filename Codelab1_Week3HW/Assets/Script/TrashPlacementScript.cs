﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPlacementScript : MonoBehaviour {

    public static TrashPlacementScript instance;

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(this);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
