using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Item[] items = new Item[3];
    [SerializeField] private Monster[] companions;

    public void RollItems()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Item[] itemList = gameManager.items;
        for (int i = 0; i < 3; i++)
        {
            items[i] = itemList[Random.Range(0, itemList.Length)];
        }
        companions = gameManager.companions;
    }
    
    void Start()
    {
        RollItems();
    }
}
