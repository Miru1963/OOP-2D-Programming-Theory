using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace


public class StartScreenManager : MonoBehaviour
{
    public TMP_InputField playerNameInput; // Reference to the InputField for player name
    public Button startButton; // Reference to the Start Button
    
    private void Start()
    {
        // Add listener to the button
        startButton.onClick.AddListener(OnStartButtonClicked); // Subscribe to button click event
    }

    private void OnStartButtonClicked() // Method called when the start button is clicked
    {
        string playerName = playerNameInput.text; // Get the player name from the input field

        if (!string.IsNullOrEmpty(playerName)) // Check if the player name is not empty
        {
            Debug.Log($"Player Name: {playerName}"); // Log the player name
            // Proceed to the next scene or start the game
            // Example: UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.LogWarning("Player name is empty!"); // Warn if the player name is empty
        }
    }
}
