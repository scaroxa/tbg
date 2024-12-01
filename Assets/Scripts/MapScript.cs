using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    [SerializeField] private GameObject popup;
    [SerializeField] private GameObject[] comps;
    [SerializeField] private Playerscript player;
    [SerializeField] private TMP_Text exp;
    [SerializeField] private TMP_Text level;
    [SerializeField] private TMP_Text floor;
    [SerializeField] private TMP_Text gold;

    void FixedUpdate()
    {
        for (int i = 0; i < player.companions.Length; i++)
        {
            comps[i].SetActive(true);
            comps[i].transform.Find("Health").GetComponent<TMP_Text>().text = player.companions[i].hp.ToString();
            comps[i].transform.Find("Attack").GetComponent<TMP_Text>().text = player.companions[i].atk.ToString();
            comps[i].transform.Find("Defense").GetComponent<TMP_Text>().text = player.companions[i].def.ToString();
            comps[i].transform.Find("Speed").GetComponent<TMP_Text>().text = player.companions[i].spd.ToString();
            comps[i].transform.Find("Name").GetComponent<TMP_Text>().text = player.companions[i].companionname;
            comps[i].transform.Find("Image").GetComponent<Image>().sprite = player.companions[i].picture;
        }
        exp.text = player.experience + "/" + 100 * player.level;
        level.text = "LVL " + player.level;
        floor.text = "Ebene " + player.floor;
        gold.text = player.gold + "g";
    }

    public void ClosePopup()
    {
        popup.GetComponent<Image>().enabled = false;
        foreach (Transform child in popup.transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void GetItem() // Remove this when Map Old scene gets deleted!
    {
        popup.SetActive(true);
    }
}
