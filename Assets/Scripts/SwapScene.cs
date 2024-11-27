using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    public void SwapToCombat()
    {
        SceneManager.LoadScene (sceneBuildIndex:1);
    }
    
    public void SwapToShop()
    {
        SceneManager.LoadScene (sceneBuildIndex:2);
    }
    
    public void SwapToMap()
    {
        SceneManager.LoadScene (sceneBuildIndex:0);
    }
}
