using UnityEngine;
using TMPro; // Import TextMeshPro namespace


public class CupL3 : Cup // INHERITANCE
{

    [SerializeField]
    private TextMeshProUGUI l3CupText; // Serialized field
    [SerializeField]
    private GameObject l3Cup; // Serialized field

    [HideInInspector]
    private new TextMeshProUGUI cupText; // Hide inherited field
    [HideInInspector]
    private new GameObject winCup; // Hide inherited field


    public override void DisplayText() // POLYMORPHISM
    {
        if (l3CupText != null)
        {
            // Display the desired text when the cup is clicked
            l3CupText.text = "Congratulations! This is the Virtual Cup you can win on Level 3. Enoy the game!";
            Debug.Log("CupL3 Text: " + l3CupText.text);
        }
        else
        {
            Debug.LogWarning("l3CupText reference is not set.");
        }

    }


    void OnMouseDown()
    {

        // Display the desired text when the cup is clicked
        DisplayText();

    }

    public GameObject GetL3Cup() //ENCAPSULATION
    {
        return l3Cup;
    }
}
