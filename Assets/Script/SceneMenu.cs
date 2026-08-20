using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("Scene01");  
    }

    public void Exit()
    {
    Application.Quit();
    }
}
