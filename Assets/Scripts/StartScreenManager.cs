using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

public class StartScreenManager : MonoBehaviour
{
    public TMP_InputField playerNameInput; // Change InputField to TMP_InputField
    public Button startButton;

    private void Start()
    {
        // Add listener to the button
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void OnStartButtonClicked()
    {
        string playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName) && playerName != "Please enter your name")
        {
            Debug.Log($"Player Name: {playerName}");
            // Proceed to the next scene or start the game
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            Debug.LogWarning("Player name is empty!");
        }
    }
}