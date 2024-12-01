using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneName: "Main Menu");
    }
    
    public void NewGame()
    {
        SceneManager.LoadScene(sceneName: "New Game");
    }
    
    public void Gacha()
    {
        SceneManager.LoadScene(sceneName: "Gacha");
    }
    
    public void Options()
    {
        SceneManager.LoadScene(sceneName: "Options");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SwapToMap()
    {
        SceneManager.LoadScene(sceneName: "Map");
    }
    
    public void SwapToCombat()
    {
        SceneManager.LoadScene(sceneName: "Combat");
    }
    
    public void SwapToShop()
    {
        SceneManager.LoadScene (sceneName: "Shop");
    }
    
    public void CloseShop()
    {
        SceneManager.UnloadSceneAsync(sceneName: "Shop");
    }
    
    public void CloseCombat()
    {
        SceneManager.UnloadSceneAsync(sceneName: "Combat");
    }
}
