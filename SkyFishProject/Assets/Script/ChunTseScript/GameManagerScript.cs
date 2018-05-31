using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : GenericSingletonClass<GameManagerScript>
{
    public GameObject FishingPanel;
    public string Gamestat;

	// Use this for initialization
	void Start () {
        Gamestat = "NormalStat";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
