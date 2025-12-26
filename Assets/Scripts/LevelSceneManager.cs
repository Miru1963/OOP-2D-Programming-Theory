using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class LevelSceneManager : MonoBehaviour
{


    private string playerName;
    public Button backButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Add listener to the button
        backButton.onClick.AddListener(OnBackButtonClicked); // Reusing the method name for simplicity
        playerName = MainDataManager.Instance.playerName; // Get the player name from MainDataManager


    }

    

    private void OnBackButtonClicked()
    {
        // Load the start screen scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(1); // Assuming the start screen scene is at index 0
        MainDataManager.Instance.SetActiveLevelIndex(1); // Set the active level index to 1 start screen

    }


}
