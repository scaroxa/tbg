using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Level[] levelList;
    [SerializeField] private Map map;
    [SerializeField] private int ebene;
    public Item[] items;
    [SerializeField] private Monster[] monsters;
    public Monster[] companions;

    public void levelUp()
    {
        // Implement
    }

    public void generateMap()
    {
        // Implement
    }
}
