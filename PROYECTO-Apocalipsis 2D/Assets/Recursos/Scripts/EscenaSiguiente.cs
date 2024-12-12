using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public float delay = 5f; // Tiempo antes de cambiar de escena

    void Start()
    {
        // Llama al cambio de escena después del retraso especificado
        Invoke("LoadMenuScene", delay);
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Reemplaza "MenuScene" con el nombre exacto de tu escena del menú
    }
}