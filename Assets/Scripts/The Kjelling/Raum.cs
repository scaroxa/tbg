using UnityEngine;

public class Raum : MonoBehaviour
{
    [SerializeField] private string raumName;
    [SerializeField] private bool aufgedeckt;
    [SerializeField] private bool cleared;
    [SerializeField] private Raum parentRaum;
    [SerializeField] private Raum[] childRaeume;

    public void Type()
    {
        if (raumName == "Combat")
        {
            // Load combat scene, which then loads the player and monster data with a fight script
        }
        else if (raumName == "Shop")
        {
            // Change upper buttons to random items
            // Change lower buttons to companions (if available)
        }
        else if (raumName == "Item")
        {
            // Grab a random item from the game manager and add it to the player's inventory
            // Show a message that the player found an item
        }
        else if (raumName == "Recovery")
        {
            // Heal the players companions and restore their ap
        }
        else if (raumName == "Boss")
        {
            // Load combat scene, which then loads the player and monster data with a boss fight script
        }
        else if (raumName == "Final Boss")
        {
            // Load combat scene, which then loads the player and monster data with a final boss fight script
        }
    }
}
