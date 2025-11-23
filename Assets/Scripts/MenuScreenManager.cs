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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Add listener to the button
        backButton.onClick.AddListener(OnBackButtonClicked); // Reusing the method name for simplicity

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBackButtonClicked()
    {
        // Load the start screen scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }





}
