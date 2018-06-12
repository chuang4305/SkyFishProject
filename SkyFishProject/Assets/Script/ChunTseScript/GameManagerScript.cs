using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
		
        if (Gamestat == "BattleStat")
        {
            FishingPanel.SetActive(false);
            SceneManager.LoadScene("Tyler_Scene");
        }
	}
}
