using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameManager myGameManager;

    void Start()
    {
        // Encuentra una instancia del GameManager
        myGameManager = FindFirstObjectByType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ItemGood"))
        {
            Destroy(collision.gameObject);
            myGameManager.AddScore(); // Incrementa la puntuación
        }
        else if (collision.CompareTag("ItemBad"))
        {
            Destroy(collision.gameObject);
            myGameManager.SubtractScore(); // Resta puntos
        }
        else if (collision.CompareTag("DeathZone"))
        {
            PlayerDeath(); // Reinicia el nivel
        }
    }

    void PlayerDeath()
    {
        SceneManager.LoadScene("PrimerNivel");
    }
}
