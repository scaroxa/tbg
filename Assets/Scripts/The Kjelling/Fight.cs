using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField] private Monster[] monsters;
    [SerializeField] private int goldReward;
    [SerializeField] private int expReward;
    [SerializeField] private Item[] itemReward; // Nur für Bossfights
}
