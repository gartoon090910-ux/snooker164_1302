using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject adjustPanel;
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

    public void ShowHideAdjustPanel(bool flag)
    {
        adjustPanel.SetActive(flag);
    }

    public void SetVolume(float volume)
    {
        AudioManager.instance.AdjustMasterVolume(volume);
    }
}
