using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string itemName;
    [SerializeField] private string[] statNames;
    [SerializeField] private double[] statValues;
    
    public void ItemEffect()
    {
        Player player = GameObject.Find("Player").GetComponent<Player>();
        foreach (Monster i in player.companions)
        {
            for (int j = 0; j < statNames.Length; j++)
            {
                if (statNames[j] == "hp") i.hp += (int)(i.hp * statValues[j]);
                if (statNames[j] == "atk") i.atk += (int)(i.atk * statValues[j]);
                if (statNames[j] == "def") i.def += (int)(i.def * statValues[j]);
                if (statNames[j] == "spd") i.spd += (int)(i.spd * statValues[j]);
            }
        }
    }
}
