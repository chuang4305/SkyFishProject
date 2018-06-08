using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UnityStandardAssets.CrossPlatformInput
{

    public class EnableCombo : MonoBehaviour
    {
        private Manager GM;

        // author: Kamil104
        // http://answers.unity3d.com/users/225838/kamil1064.html

        public GameObject comboPanel;
        public KeyCode startCombo;
        public float _timer;
        public int _comboLength;
        public float h;
        public float v;

        public Button m_YourButton;


        private void Awake()
        {
            GM = Manager.GM;
        }

        // Use this for initialization
        void Start()
        {
            Button btn = m_YourButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);

        }

        void TaskOnClick()
        {
            //if (Input.GetKeyDown(startCombo) && comboPanel.activeSelf == false) // if you press key and combo game isn't already started
            //{
            if (GM.isPlayerTurn == true) {
                
            comboPanel.SetActive(true);

            comboPanel.GetComponent<fight_combo>().SetUpGame(_timer, _comboLength); // sending timer and cobmo length data
                                                                   
                             //Output this to console when the Button is clicked
            Debug.Log("You have clicked the button!");

                GM.isPlayerTurn = false;

            }else{
                print("cannot attack");
            }
        }

        // Update is called once per frame
        void Update()
        {

          
        }
    }
}