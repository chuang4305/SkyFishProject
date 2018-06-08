using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fight_combo : MonoBehaviour
{
    private Manager GM;
    // author: Kamil104
    // http://answers.unity3d.com/users/225838/kamil1064.html
    public Image[] images; // imgaes to show which buton you need to press
    public KeyCode[] keys; // keys you need to press
    private float timer; // time which you have to press
    private float sorryTimer = 0;
    private int current;
    private int comboLength; // how many times you need to press correct key
    private int currentCombo = 0;
    public int damage;
    public GameObject Enemy;


    private void Awake()     {         GM = Manager.GM;     }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > sorryTimer)
        {
            SetTimer(false);
        }
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(keys[current]))
            {
              
                SetTimer(true);
            }
            else
            {
                //damage = damage - 2;
                //print("wrong key was pressed: reduced damage = 2;");
                //gameObject.SetActive(false);
            }
        }


        images[current].fillAmount = (sorryTimer - Time.time) / timer;
    }
    public void SetTimer(bool fastEnough)
    {

        if (currentCombo >= comboLength)
        {
            images[current].fillAmount = 0;
            // print("you won :)");
            print(GM.PlayerDamage);
            // do some stuff here
            gameObject.SetActive(false);
            GM.EnemyHealth -= GM.PlayerDamage;
            Enemy.SetActive(true);
        }
        else
        {
            sorryTimer = Time.time + timer;
            images[current].fillAmount = 0;
            current = Random.Range(0, images.Length);
            if (!fastEnough)
            {
                print("failed to press key: reduced damage = 2");
                // and do die stuff here
            }
            else
            {
                print("Nice");
                GM.PlayerDamage += 2;
            }
            currentCombo++;
        }
    }
    public void SetUpGame(float my_timer, int my_comboLength)
    {
        timer = my_timer;
        comboLength = my_comboLength;
        sorryTimer = Time.time + timer;
        currentCombo = 1;
    }
}