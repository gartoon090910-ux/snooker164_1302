using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    private void Start()
    {
        AudioManager.instance.PlayBGM(0);
    }
    public void Startgame()
    {
        Settings.fromSave = false;
        SceneManager.LoadScene("Loading");  
    }

    public void LoadSavedNewGame()
    {
        Settings.fromSave = true;
        SceneManager.LoadScene("Loading");
    }

    public void Exit()
    {
    Application.Quit();
    }
}
