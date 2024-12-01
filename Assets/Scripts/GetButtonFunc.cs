using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetButtonFunc : MonoBehaviour
{
    private GameObject popup;
    private Button current;
    private void fight()
    {
        SceneManager.LoadScene(sceneName: "Combat", LoadSceneMode.Additive);
    }
    private void shop()
    {
        SceneManager.LoadScene(sceneName: "Shop", LoadSceneMode.Additive);
    }
    private void item()
    {
        popup.GetComponent<Image>().enabled = true;
        foreach (Transform child in popup.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
    private void recovery()
    {
        popup.GetComponent<Image>().enabled = true;
        foreach (Transform child in popup.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
    
    private void TurnOffButton()
    {
        current.interactable = false;
    }
    void Start()
    {
        //Debug.Log("Instantiated button");
        popup = GameObject.FindGameObjectWithTag("Popup");
        current = gameObject.GetComponent<Button>();
        current.onClick.AddListener(TurnOffButton);
        switch(gameObject.name)
        {
            case "Combatroom(Clone)":
                current.onClick.AddListener(fight);
                break;
            case "Bossroom(Clone)":
                current.onClick.AddListener(fight);
                break;
            case "Finalbossroom(Clone)":
                current.onClick.AddListener(fight);
                break;
            case "Shoproom(Clone)":
                current.onClick.AddListener(shop);
                break;
            case "Recoveryroom(Clone)":
                current.onClick.AddListener(recovery);
                break;
            case "Itemroom(Clone)":
                current.onClick.AddListener(item);
                break;
            default:
                break;
        }
    }
}
