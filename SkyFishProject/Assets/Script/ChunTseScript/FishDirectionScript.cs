using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishDirectionScript : GenericSingletonClass<FishDirectionScript>
{

    public int fishDir;
    public int fishLv;
    public float timer;
   

	// Use this for initialization
	void Start () {

        fishLv = 1;

        //Determine LV of the fish
        if (fishLv == 1) // 1 = common
        {
            timer = 5;
        }

        else if (fishLv == 2) // 2 = uncome
        {
            timer = 2;
        }

        else if (fishLv == 3) // 3 = Legendary
        {
            timer = 1;
        }

        InvokeRepeating("ChangeDr", 0, timer);

    }
	
	// Update is called once per frame
	void Update () {


        //Change Direction of Fish
        if (fishDir == 1)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0); //upward
        }

        if (fishDir == 2)
        {
            transform.localEulerAngles = new Vector3(0, 0, 90); // left
        }

        if (fishDir == 3)
        {
            transform.localEulerAngles = new Vector3(0, 0, -90); //right
        }

        if (fishDir == 4)
        {
            transform.localEulerAngles = new Vector3(0, 0, 180); //down
        }

        if (fishDir == 5)
        {
            transform.localEulerAngles = new Vector3(0, 0, 45); //up left
        }

        if (fishDir == 6)
        {
            transform.localEulerAngles = new Vector3(0, 0, -45); //up right
        }

        if (fishDir == 7)
        {
            transform.localEulerAngles = new Vector3(0, 0, 135); //down left
        }

        if (fishDir == 8)
        {
            transform.localEulerAngles = new Vector3(0, 0, -135); // down right
        }



    }

    void ChangeDr()
    {
        Debug.Log("Pick Direction");
        fishDir = Random.Range(1,8);
        CheckCHit();
        FishingScript.Instance.canPress = true;

    }

    void CheckCHit()
    {
        if (FishingScript.Instance.noHit == false)
        {
            FishingScript.Instance.fishMeter += 1;
        }
        else
        {
            FishingScript.Instance.fishMeter -= 1;
        }

        FishingScript.Instance.noHit = true;
    }
}
