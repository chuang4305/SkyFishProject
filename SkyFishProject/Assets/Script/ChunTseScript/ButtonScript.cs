﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Fishing()
    {
        GameManagerScript.Instance.FishingPanel.SetActive(true);
        GameManagerScript.Instance.Gamestat = "FishingStat";
    }
}
