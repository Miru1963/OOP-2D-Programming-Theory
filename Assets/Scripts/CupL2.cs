using UnityEngine;
using TMPro; // Import TextMeshPro namespace


public class CupL2 : Cup
{
    
    [SerializeField]
    private TextMeshProUGUI l2CupText; // Serialized field
    [SerializeField]
    private GameObject l2Cup; // Serialized field

    [HideInInspector]
    private new TextMeshProUGUI cupText; // Hide inherited field
    [HideInInspector]
    private new GameObject winCup; // Hide inherited field


    public override void DisplayText() // Override method
    {
        if (l2CupText != null)
        {
            // Display the desired text when the cup is clicked
            l2CupText.text = "Congratulations! This is the Virtual Cup you can win on Level 2. Enoy the game!";
            Debug.Log("CupL2 Text: " + l2CupText.text);
        }
        else
        {
            Debug.LogWarning("l2CupText reference is not set.");
        }

    }


    void OnMouseDown()
    {

        // Display the desired text when the cup is clicked
        DisplayText();

    }

    public GameObject GetL2Cup()
    {
        return l2Cup;
    }
}
