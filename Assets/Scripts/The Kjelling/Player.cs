using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int gold;
    [SerializeField] private Item[] items;
    public Monster[] companions = new Monster[3];
    public Monster activeCompanion;
    private Dictionary<string, double> dmgmult = new();

    public void Attack()
    {
        // Implement
    }
    
    public void TakeDamage(Attack attack)
    {
        if (!(attack.element == "Normal" || activeCompanion.element == "Normal" || attack.element == "Heal"))
        {
            double multiplier = dmgmult[attack.element + activeCompanion.element];
            int damage = (int)(attack.damage * multiplier);
            activeCompanion.hp -= damage;
        }
        else
        {
            activeCompanion.hp -= attack.damage;
        }
        if (activeCompanion.hp <= 0) activeCompanion.hp = 0;
    }

    void Start()
    {
        dmgmult.TryAdd("FireFire", 1);
        dmgmult.TryAdd("FireWater", 0.5);
        dmgmult.TryAdd("FireEarth", 2);
        dmgmult.TryAdd("WaterFire", 2);
        dmgmult.TryAdd("WaterWater", 1);
        dmgmult.TryAdd("WaterEarth", 0.5);
        dmgmult.TryAdd("EarthFire", 0.5);
        dmgmult.TryAdd("EarthWater", 2);
        dmgmult.TryAdd("EarthEarth", 1);
    }
}
