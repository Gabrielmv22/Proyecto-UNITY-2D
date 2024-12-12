using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipalBotones : MonoBehaviour
{
    // Método para cargar la escena del juego
    public void PlayGame()
    {
        SceneManager.LoadScene("PrimerNivel"); // Reemplaza con el nombre exacto de tu escena de juego
    }

    public void VolverScene()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Reemplaza con el nombre exacto de tu escena de juego
    }

    // Método para cargar la escena de opciones
    public void Options()
    {
        SceneManager.LoadScene("Opciones"); // Reemplaza con el nombre exacto de tu escena de opciones
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Debug.Log("Quit Game!"); // Esto aparece solo en el Editor
        Application.Quit(); // Cierra la aplicación en una compilación
    }
}