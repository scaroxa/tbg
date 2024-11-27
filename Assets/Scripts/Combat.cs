using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Combat : MonoBehaviour
{
    private Dictionary<string, double> dmgmult = new();
    public int maxplayerhp = 100;
    public int maxenemyhp = 100;
    private int playerhp = 100;
    private int enemyhp = 100;
    public int basedmg = 20;

    public string playerelement;
    public string enemyelement;

    public TMP_Dropdown playerdropdown;
    public TMP_Dropdown enemydropdown;
    public TMP_Text playerbar;
    public TMP_Text enemybar;

    private void AddElements()
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
    
    public int deal_damage(int targethp, int dmg, string dmgtype, string deftype)
    {
        if (!(dmgtype == "Normal" || deftype == "Normal"))
        {
            dmgmult.TryGetValue(dmgtype + deftype, out double multvalue);
            dmg = (int)(dmg * multvalue);
        }
        
        if (targethp - dmg < 0) targethp = 0;
        else targethp -= dmg;

        return targethp;
    }
    
    public void Pfireattack()
    {
        Debug.Log("Fire attack");
        enemyhp = deal_damage(enemyhp, 20, "Fire", enemyelement);
    }
    
    public void Pwaterattack()
    {
        Debug.Log("Water attack");
        enemyhp = deal_damage(enemyhp, 20, "Water", enemyelement);
    }
    
    public void Pearthattack()
    {
        Debug.Log("Earth attack");
        enemyhp = deal_damage(enemyhp, 20, "Earth", enemyelement);
    }
    
    public void Enemyattack()
    {
        Debug.Log("Enemy attack");
        playerhp = deal_damage(playerhp, 20, "Normal", playerelement);
    }
    
    public void Playerheal()
    {
        Debug.Log("Player Heal");
        if (playerhp + 20 > maxplayerhp) playerhp = maxplayerhp;
        else playerhp += 20;
    }
    
    public void Enemyheal()
    {
        Debug.Log("Enemy Heal");
        if (enemyhp + 20 > maxenemyhp) enemyhp = maxenemyhp;
        else enemyhp += 20;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AddElements();
    }

    // Update is called once per frame
    void Update()
    {
        playerbar.text = playerhp + "/" + maxplayerhp + " HP";
        enemybar.text = enemyhp + "/" + maxenemyhp + " HP";
        if (enemyhp <= 0) SceneManager.LoadScene(sceneBuildIndex: 0);
        playerelement = playerdropdown.captionText.text;
        enemyelement = enemydropdown.captionText.text;
    }
}
