using UnityEngine;
using UnityEngine.SceneManagement;
public class VitoriaManager : MonoBehaviour

{
    public GameObject uiVitoria;
    public GameObject textVitoria;

    public void Vitoria()
    {
        uiVitoria.SetActive(true);
        Time.timeScale = 0f; // pausa o jogo
        textVitoria.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    }



