using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static Manager GM;

    public int PlayerDamage;
    public int PlayerHealth;
    public int EnemyHealth;
    public int EnemyDamage;

    public bool isPlayerTurn = true;

    public Text PlayerdamageText;
    public Text PlayerHealthText;

    // Use this for initialization
    private void Awake()
    {
        isPlayerTurn = true;

        if (Manager.GM != null)
            Destroy(gameObject);
        else
            GM = this;

        PlayerDamage = 1;
        PlayerHealth= 50;
        EnemyHealth = 55;
    }

    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerdamageText.text = "Player Damage = " + PlayerDamage;
        PlayerHealthText.text = "Player Health = " + PlayerHealth;


        }

	}
