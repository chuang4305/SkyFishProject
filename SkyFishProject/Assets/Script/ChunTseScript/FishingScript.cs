using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingScript : GenericSingletonClass<FishingScript>
{

    public int currentFishDr;
    public int fishMeter;
    public bool canPress;

	// Use this for initialization
	void Start () {

        //currentFishDr = FishDirectionScript.Instance.fishDir;
        fishMeter = 5;
	}

    // Update is called once per frame
    void Update()
    {
        if (GameManagerScript.Instance.Gamestat == "FishingStat")
        {
            currentFishDr = FishDirectionScript.Instance.fishDir; // get the current fish direction

            if (currentFishDr == 1 && Input.GetKeyDown(KeyCode.DownArrow) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (currentFishDr == 2 && Input.GetKeyDown(KeyCode.RightArrow) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (currentFishDr == 3 && Input.GetKeyDown(KeyCode.LeftArrow) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (currentFishDr == 4 && Input.GetKeyDown(KeyCode.UpArrow) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (currentFishDr == 5 && Input.GetKeyDown(KeyCode.E) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (currentFishDr == 6 && Input.GetKeyDown(KeyCode.Q) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (currentFishDr == 7 && Input.GetKeyDown(KeyCode.D) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (currentFishDr == 8 && Input.GetKeyDown(KeyCode.A) && canPress == true)
            {
                fishMeter += 1;
                canPress = false;
            }

            else if (Input.anyKeyDown && canPress == true)
            {
                fishMeter -= 1;
                canPress = false;
            }

            else if (FishDirectionScript.Instance.timer == 0)
            {
                fishMeter -= 1;
                canPress = false;
            }
            Debug.Log(canPress);
        }
    }
}
