using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private bool canMove; // to control when the player can move
                                               //[SerializeField] private GameplayUI gameplayUI; // reference to the GameplayUI script
        

        private Rigidbody2D rb; // reference to the Rigidbody2D component
        private float speed = 15; // speed of the player
        private int activeLevelIndex = 0; // Variable to store active level index



        public GameObject winText;
        
        public GameObject cupL1, cupL2, cupL3; // Reference to the CupL GameObject
        public GameObject l1Cup, l2Cup, l3Cup; // Reference to the L Cup GameObject



        private void Start()
        {
            
                rb = GetComponent<Rigidbody2D>(); // get the Rigidbody2D component
              canMove = true; // allow movement at the start
            
        }

        private void Update()
        {
            if (canMove) // only allow movement when canMove is true
            {
                WASDAndArrowsMove(); // for keyboard controls
                
            }
        }

        

        void DoSomething()
        {
            canMove = false;
            Debug.Log($"canMove = false gesetzt");
            //AudioManager.instance.PlayFirstSound();
    }

        private void WASDAndArrowsMove()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                rb.linearVelocity = Vector2.up * speed;
                Debug.Log($"Up key pressed"); 
                DoSomething();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                rb.linearVelocity = Vector2.down * speed;
                Debug.Log($"Down key pressed");
                DoSomething();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                rb.linearVelocity = Vector2.left * speed;
                Debug.Log($"Left key pressed");
                DoSomething();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                rb.linearVelocity = Vector2.right * speed;
                Debug.Log($"Right key pressed");
                DoSomething();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision) // when the player collides with something   
        {
            canMove = true;
            Debug.Log($"canMove = true gesetzt");
            var xValue = Math.Round(gameObject.transform.position.x, 1); // round the position to 1 decimal place
            var yValue = Math.Round(gameObject.transform.position.y, 1); // round the position to 1 decimal place
            gameObject.transform.position = new Vector2((float)xValue, (float)yValue); //set the position to the rounded values
            


    }

        private void OnTriggerEnter2D(Collider2D collision) // when the player enters a trigger collider
        {
            

        if (collision.CompareTag("Win")) // if the player enters the win zone
        {

            activeLevelIndex = MainDataManager.Instance.GetActiveLevelIndex(); // get the active level index from MainDataManager
            Debug.LogWarning($"Active Level Index: {activeLevelIndex}");

            

            switch (activeLevelIndex)
            {
                case 2: // Level 1
                        // Activate the l1Cup GameObject to display the big picture
                    CupL1 cupScript = cupL1.GetComponent<CupL1>(); // get the CupL1 script from the cupL1 GameObject
                    if (cupScript != null) // check if the script is found
                    {
                        Debug.LogWarning("cupScript != null"); // Debug log to confirm script is found
                        GameObject l1Cup = cupScript.GetL1Cup(); // get the l1Cup GameObject from the CupL1 script
                        if (l1Cup != null) // check if the l1Cup GameObject is found
                        {
                            Debug.LogWarning("l1Cup != null"); // Debug log to confirm l1Cup is found
                            l1Cup.SetActive(true); // activate the l1Cup GameObject
                            l1Cup.transform.localScale = new Vector3(10.0f, 10.0f, 10.0f); // Adjust the scale as needed
                        }
                        else
                        {
                            Debug.LogWarning("l1Cup reference is not set."); // Debug log if l1Cup is not found
                        }
                    }

                    Debug.LogWarning("Level 1 completed!");
                    break;

                case 3: // Level 2
                    CupL2 cupScriptL2 = cupL2.GetComponent<CupL2>(); // get the CupL script from the cupL1 GameObject
                    if (cupScriptL2 != null) // check if the script is found
                    {
                        Debug.LogWarning("cupScript != null"); // Debug log to confirm script is found
                        GameObject l2Cup = cupScriptL2.GetL2Cup(); // get the l1Cup GameObject from the CupL1 script
                        if (l2Cup != null) // check if the l1Cup GameObject is found
                        {
                            Debug.LogWarning("l2Cup != null"); // Debug log to confirm l1Cup is found
                            l2Cup.SetActive(true); // activate the l1Cup GameObject
                            l2Cup.transform.localScale = new Vector3(10.0f, 10.0f, 1.0f); // Adjust the scale as needed
                        }
                        else
                        {
                            Debug.LogWarning("l2Cup reference is not set."); // Debug log if l2Cup is not found
                        }
                    }
                    Debug.LogWarning("Level 2 completed!");
                    break;

                case 4: // Level 3
                    CupL3 cupScriptL3 = cupL3.GetComponent<CupL3>(); // get the CupL script from the cupL1 GameObject
                    if (cupScriptL3 != null) // check if the script is found
                    {
                        Debug.LogWarning("cupScriptL3 != null"); // Debug log to confirm script is found
                        GameObject l3Cup = cupScriptL3.GetL3Cup(); // get the l1Cup GameObject from the CupL1 script
                        if (l3Cup != null) // check if the l3Cup GameObject is found
                        {
                            Debug.LogWarning("l3Cup != null"); // Debug log to confirm l3Cup is found
                            l3Cup.SetActive(true); // activate the l3Cup GameObject
                            l3Cup.transform.localScale = new Vector3(10.0f, 10.0f, 1.0f); // Adjust the scale as needed
                        }
                        else
                        {
                            Debug.LogWarning("l3Cup reference is not set."); // Debug log if l3Cup is not found
                        }
                    }
                    Debug.LogWarning("Level 3 completed!");
                    break;



                default:
                    break;
            }


           
            //Debug.Log($"Win zone passed");
            winText.SetActive(true); // show the win text
            //gameplayUI.LevelWin(); // call the LevelWin function in the GameplayUI script
            Destroy(gameObject, 3); // destroy the player after 3 seconds
        }
        }
    }
