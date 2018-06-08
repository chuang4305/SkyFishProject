using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTurn : MonoBehaviour {
    private Manager GM;

    private void Awake()
    {
        GM = Manager.GM;
    }


    // Use this for initialization
    private void Start()
    {
        
    }

    void OnEnable () {
        Debug.Log("Has been Enabled");
        Invoke("DisableObject",5);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DisableObject(){
        GM.PlayerHealth -= Random.Range(4, 8);
        GM.PlayerDamage = 1;
        GM.isPlayerTurn = true;
        gameObject.SetActive(false);

    }

}
