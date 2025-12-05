using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class CupL1 : Cup
{
    //private string farbe, name, text; // Private field
    [SerializeField]
    private TextMeshProUGUI l1CupText;
    [SerializeField]
    private GameObject l1Cup; // Serialized field

    [HideInInspector]
    private new TextMeshProUGUI cupText; // Hide inherited field
    [HideInInspector]
    private new GameObject winCup; // Hide inherited field


    /*
    public CupL1(string farbe) // Constructor
    {
        this.farbe = farbe; // Assign the parameter to the field
    }

    public CupL1() { } // Default constructor

    /*
    public string Farbe // Property
    {
        get { return farbe; }
        set { farbe = value; }
    }
    public string Name // Property
    {
        get { return name; }
        set { name = value; }
    }
    public string Text // Property
    {
        get { return text; }
        set { text = value; }
    }
    */

    public override void DisplayText() // Override method
    {
        if (l1CupText != null)
        {
            // Display the desired text when the cup is clicked
            l1CupText.text = "Congratulations! This is the Virtual Cup you can win on Level 1. Enoy the game!";
            Debug.Log("CupL1 Text: " + l1CupText.text);
        }
        else
        {
            Debug.LogWarning("l1CupText reference is not set.");
        }

    }

    
    void OnMouseDown()
    {
        
            // Display the desired text when the cup is clicked
            DisplayText();
        
    }

    public GameObject GetL1Cup()
    {
        return l1Cup;
    }


}
