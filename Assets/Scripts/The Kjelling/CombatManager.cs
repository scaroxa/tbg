using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Player enemy;
    [SerializeField] private Button tl, tr, bl, br, fight, swap, back, swap1, swap2, swap3;
    [SerializeField] private TMP_Text tlText, trText, blText, brText, fightText, swapText, swap1Text, swap2Text, swap3Text;
    [SerializeField] private TMP_Text playername, enemyname, playerhp, enemyhp, playerap;
    [SerializeField] private Image playerSprite, enemySprite;

    void Start()
    {
        player.activeCompanion = player.companions[0];
        enemy.activeCompanion = enemy.companions[0];
        playername.text = player.activeCompanion.name;
        playerSprite.sprite = player.activeCompanion.sprite;
        enemyname.text = enemy.activeCompanion.name;
        enemySprite.sprite = enemy.activeCompanion.sprite;
        tl.onClick.AddListener(() => ApCheck(player, enemy, player.activeCompanion.attacks[0]));
        tr.onClick.AddListener(() => ApCheck(player, enemy, player.activeCompanion.attacks[1]));
        bl.onClick.AddListener(() => ApCheck(player, enemy, player.activeCompanion.attacks[2]));
        br.onClick.AddListener(() => ApCheck(player, player, player.activeCompanion.attacks[3]));
        tlText.text = player.activeCompanion.attacks[0].name + "\n" + player.activeCompanion.attacks[0].apCost + " AP";
        trText.text = player.activeCompanion.attacks[1].name + "\n" + player.activeCompanion.attacks[1].apCost + " AP";
        blText.text = player.activeCompanion.attacks[2].name + "\n" + player.activeCompanion.attacks[2].apCost + " AP";
        brText.text = player.activeCompanion.attacks[3].name + "\n" + player.activeCompanion.attacks[3].apCost + " AP";
        swap1.onClick.AddListener(() => SwapCompanion(0));
        swap2.onClick.AddListener(() => SwapCompanion(1));
        swap3.onClick.AddListener(() => SwapCompanion(2));
        swap1Text.text = player.companions[0] == null ? "" : player.companions[0].name;
        swap2Text.text = player.companions[1] == null ? "" : player.companions[1].name;
        swap3Text.text = player.companions[2] == null ? "" : player.companions[2].name;
}

    void Update()
    {
        playerhp.text = player.activeCompanion.hp.ToString();
        playerap.text = player.activeCompanion.ap.ToString();
        enemyhp.text = enemy.activeCompanion.hp.ToString();
    }

    public void ApCheck(Player user, Player target, Attack attack)
    {
        if (user.activeCompanion.ap >= attack.apCost)
        {
            user.activeCompanion.ap -= attack.apCost;
            target.TakeDamage(attack);
        }
    }

    public void SwapCompanion(int number)
    {
        player.activeCompanion = player.companions[number] == null ? player.activeCompanion : player.companions[number];
        playername.text = player.activeCompanion.name;
        playerSprite.sprite = player.activeCompanion.sprite;
        
    }
    
    public void ShowAbilities()
    {
        fight.gameObject.SetActive(false);
        swap.gameObject.SetActive(false);
        tl.gameObject.SetActive(true);
        tr.gameObject.SetActive(true);
        bl.gameObject.SetActive(true);
        br.gameObject.SetActive(true);
        back.gameObject.SetActive(true);
    }

    public void ShowSwaps()
    {
        fight.gameObject.SetActive(false);
        swap.gameObject.SetActive(false);
        swap1.gameObject.SetActive(true);
        swap2.gameObject.SetActive(true);
        swap3.gameObject.SetActive(true);
        back.gameObject.SetActive(true);
    }

    public void HideAbilities()
    {
        fight.gameObject.SetActive(true);
        swap.gameObject.SetActive(true);
        tl.gameObject.SetActive(false);
        tr.gameObject.SetActive(false);
        bl.gameObject.SetActive(false);
        br.gameObject.SetActive(false);
        swap1.gameObject.SetActive(false);
        swap2.gameObject.SetActive(false);
        swap3.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
    }
}
