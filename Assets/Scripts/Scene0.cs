using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene0 : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void nextScene()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void exit()
    {
        Application.Quit();
    }
}
