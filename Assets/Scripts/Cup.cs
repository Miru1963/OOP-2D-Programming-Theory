using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class Cup : MonoBehaviour
{
    private string farbe, cupName, text; // Private field
    [HideInInspector]
    [SerializeField]
    private TextMeshProUGUI cupText; // Hidden in Inspector
    [HideInInspector]
    [SerializeField]
    private GameObject winCup; // Hidden in Inspector


    /*
    public Cup(string farbe) // Constructor
    {
        this.farbe = farbe; // Assign the parameter to the field
    }

    public Cup() { } // Default constructor

    */


    public string Farbe // ENCAPSULATION
    {
            get { return farbe; } // Getter
            set { farbe = value; } // Setter
     }   


   public string CupName // ENCAPSULATION
    {
        get { return cupName; } // Getter
        set { cupName = value; } // Setter
    }
    public string Text // ENCAPSULATION
    {
        get { return text; } // Getter
        set { text = value; } // Setter
    }

   

    public virtual void DisplayText() //POLYMORPHISM
    {
        // Display the desired text when the cup is clicked
        cupText.text = "You clicked the cup!";
        Debug.Log("Cup Text: " + cupText.text);
    }

    void OnMouseDown()
    {
        // Check if the cupText reference is set
        if (cupText != null)
        {
            // Display the desired text when the cup is clicked
            DisplayText();
        }
    }

}
