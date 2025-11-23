using UnityEngine;

public class MainDataManager : MonoBehaviour
{
    
    public static MainDataManager Instance; // Singleton instance

    public string playerName; // Variable to store player name


    private void Awake() // Awake is called when the script instance is being loaded
    {
        // Implement singleton pattern
        if (Instance == null) // If no instance exists
        {
            Instance = this; // Set this as the instance
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }





}
