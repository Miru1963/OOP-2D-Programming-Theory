using UnityEngine;

public class Cup : MonoBehaviour
{
    private string farbe, name, text; // Private field
    [SerializeField]
    private GameObject winText; // Serialized field
    [SerializeField]
    private GameObject winCup; // Serialized field

   

    public Cup(string farbe) // Constructor
    {
        this.farbe = farbe; // Assign the parameter to the field
    }

    public Cup() { } // Default constructor

     public string Farbe // Property
     {
            get { return farbe; } // Getter
            set { farbe = value; } // Setter
     }

   public string Name // Property
    {
        get { return name; } // Getter
        set { name = value; } // Setter
    }
    public string Text // Property
    {
        get { return text; } // Getter
        set { text = value; } // Setter
    }

   

    public virtual void DisplayText() // Virtual method
    {
        Debug.Log("Cup Text: " + text);
    }



}
