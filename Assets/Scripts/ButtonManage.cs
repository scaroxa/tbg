using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManage : MonoBehaviour
{
    [SerializeField] private Button topleft;
    [SerializeField] private Button topright;
    [SerializeField] private Button botleft;
    [SerializeField] private Button botright;
    [SerializeField] private Button topswap;
    [SerializeField] private Button midswap;
    [SerializeField] private Button botswap;
    [SerializeField] private Button fightbutton;
    [SerializeField] private Button swapbutton;
    [SerializeField] private Button backbutton;
    [SerializeField] private TMP_Text playername;
    [SerializeField] private GameObject sprite1;
    [SerializeField] private GameObject sprite2;
    [SerializeField] private GameObject sprite3;

    public void SwapOne()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(false);
        sprite3.SetActive(false);
        playername.text = "FiFi";
    }
    
    public void SwapTwo()
    {
        sprite1.SetActive(false);
        sprite2.SetActive(true);
        sprite3.SetActive(false);
        playername.text = "ErEr";
    }
    
    public void SwapThree()
    {
        sprite1.SetActive(false);
        sprite2.SetActive(false);
        sprite3.SetActive(true);
        playername.text = "WaWa";
    }

    public void ShowAbilities()
    {
        fightbutton.gameObject.SetActive(false);
        swapbutton.gameObject.SetActive(false);
        topleft.gameObject.SetActive(true);
        topright.gameObject.SetActive(true);
        botleft.gameObject.SetActive(true);
        botright.gameObject.SetActive(true);
        backbutton.gameObject.SetActive(true);
    }

    public void ShowSwaps()
    {
        fightbutton.gameObject.SetActive(false);
        swapbutton.gameObject.SetActive(false);
        topswap.gameObject.SetActive(true);
        midswap.gameObject.SetActive(true);
        botswap.gameObject.SetActive(true);
        backbutton.gameObject.SetActive(true);
    }

    public void HideAbilities()
    {
        fightbutton.gameObject.SetActive(true);
        swapbutton.gameObject.SetActive(true);
        topleft.gameObject.SetActive(false);
        topright.gameObject.SetActive(false);
        botleft.gameObject.SetActive(false);
        botright.gameObject.SetActive(false);
        topswap.gameObject.SetActive(false);
        midswap.gameObject.SetActive(false);
        botswap.gameObject.SetActive(false);
        backbutton.gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HideAbilities();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
