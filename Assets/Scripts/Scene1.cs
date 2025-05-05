using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene1 : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void exit()
    {
        Application.Quit();
    }
}
