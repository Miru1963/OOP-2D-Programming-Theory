using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro; // Import TextMeshPro namespace

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class StartScreenManager : MonoBehaviour
{
    public TMP_InputField playerNameInput; // Change InputField to TMP_InputField
    public Button startButton, exitButton;

    private void Start()
    {
        // Add listener to the buttons
        startButton.onClick.AddListener(OnStartButtonClicked); // Reusing the method name for simplicity
        exitButton.onClick.AddListener(OnExitButtonClicked); // Reusing the method name for simplicity

        if (MainDataManager.Instance != null && !string.IsNullOrEmpty(MainDataManager.Instance.playerName)) // Check if player name exists
        {
            playerNameInput.text = MainDataManager.Instance.playerName; // Set the input field to the saved player name
        }
        else
        {
            playerNameInput.text = "Please enter your name"; // Placeholder text
        }

    }

    private void OnStartButtonClicked()
    {
        string playerName = playerNameInput.text; // Get the player name from the input field

        if (!string.IsNullOrEmpty(playerName) && playerName != "Please enter your name") // Validate the player name
        {
            Debug.Log($"Player Name: {playerName}"); // Log the player name
            MainDataManager.Instance.playerName = playerName; // Save the player name to MainDataManager

            // Proceed to the next scene or start the game
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            Debug.LogWarning("Player name is empty!"); // Log a warning if the player name is invalid
        }
    }

    private void OnExitButtonClicked()
    {
        Debug.Log("Exit Button Clicked");
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode(); // Exit play mode in the Unity Editor
#else
        Application.Quit(); // original code to quit Unity player
#endif   
    
    }



    }