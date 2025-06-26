using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject TextGameover;

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        TextGameover.SetActive(true);
    }
}
