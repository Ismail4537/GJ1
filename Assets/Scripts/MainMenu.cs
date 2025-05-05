using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void keyboardControll()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Scene0");
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("Scene0");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
