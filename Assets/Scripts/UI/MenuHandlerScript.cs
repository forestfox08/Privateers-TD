using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandlerScript : MonoBehaviour
{
    public void B_StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void B_Quit()
    {
        Application.Quit();
    }
}