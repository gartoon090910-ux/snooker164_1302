using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("Loading");  
    }

    public void Exit()
    {
    Application.Quit();
    }
}
