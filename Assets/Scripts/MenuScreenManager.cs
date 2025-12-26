using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class MenuScreenManager : MonoBehaviour
{
    public Button level1Button, level2Button, level3Button;
    public Button backButton;
    public GameObject welcomeText;

    private string playerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Add listener to the button
        backButton.onClick.AddListener(OnBackButtonClicked); // Reusing the method name for simplicity
        level1Button.onClick.AddListener(OnLevel1ButtonClicked); // Add listener for Level 1 button
        level2Button.onClick.AddListener(OnLevel2ButtonClicked); // Add listener for Level 2 button
        level3Button.onClick.AddListener(OnLevel3ButtonClicked); // Add listener for Level 3 button

        playerName = MainDataManager.Instance.playerName; // Get the player name from MainDataManager
        welcomeText.GetComponent<TMP_Text>().text = "Welcome, " + playerName + "!"; // Set welcome text

    }

   

    private void OnBackButtonClicked()
    {
        // Load the start screen scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(0); // Assuming the start screen scene is at index 0
    }

    private void OnLevel1ButtonClicked()
    {
        // Load the Level 1 scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(2); // Assuming the Level 1 scene is at index 2
        MainDataManager.Instance.SetActiveLevelIndex(2); // Set the active level index to 2 for Level 1
    }

    private void OnLevel2ButtonClicked()
    {
        // Load the Level 2 scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(3); // Assuming the Level 2 scene is at index 3
        MainDataManager.Instance.SetActiveLevelIndex(3); // Set the active level index to 3 for Level 2
    }

    private void OnLevel3ButtonClicked()
    {
        // Load the Level 3 scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(4); //   
        MainDataManager.Instance.SetActiveLevelIndex(4);// Set the active level index to 4 for Level 3


    }


}
