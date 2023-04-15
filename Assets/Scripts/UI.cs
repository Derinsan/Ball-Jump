using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGameScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGameFull()
    {
        Application.Quit();
    }
}
