using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private bool canMove; // to control when the player can move
        //[SerializeField] private GameplayUI gameplayUI; // reference to the GameplayUI script
        private Rigidbody2D rb; // reference to the Rigidbody2D component
        private float speed = 10; // speed of the player

        private Vector2 startTouchPosition; // for mobile controls
        private Vector2 endTouchPosition; // for mobile controls    

        private void Start()
        {
            //gameplayUI = GameObject.Find("Gameplay").GetComponent<GameplayUI>(); // find the GameplayUI script in the scene

          rb = GetComponent<Rigidbody2D>(); // get the Rigidbody2D component
          canMove = true; // allow movement at the start
        }

        private void Update()
        {
            if (canMove) // only allow movement when canMove is true
            {
                WASDAndArrowsMove(); // for keyboard controls
                SwipeMove(); // for mobile controls
            }
        }

        private void SwipeMove() // for mobile controls
    {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startTouchPosition = Input.GetTouch(0).position;
            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endTouchPosition = Input.GetTouch(0).position;
                Vector2 inputVector = endTouchPosition - startTouchPosition;
                if (Mathf.Abs(inputVector.x) > Mathf.Abs(inputVector.y))
                {
                    if (inputVector.x > 0)
                    {
                        rb.linearVelocity = Vector2.right * speed;
                        DoSomething();
                    }
                    else
                    {
                        rb.linearVelocity = Vector2.left * speed;
                        DoSomething();
                    }
                }
                else
                {
                    if (inputVector.y > 0)
                    {
                        rb.linearVelocity = Vector2.up * speed;
                        DoSomething();
                    }
                    else
                    {
                        rb.linearVelocity = Vector2.down * speed;
                        DoSomething();
                    }
                }
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
            Debug.Log($"Win zone passed");
            //gameplayUI.LevelWin(); // call the LevelWin function in the GameplayUI script
            Destroy(gameObject, 3); // destroy the player after 3 seconds
        }
        }
    }
