using UnityEngine;

public class Camara2D : MonoBehaviour
{
    public Transform targetPlayer; // Referencia al jugador
    public float verticalOffset = 2.0f; // Offset para elevar la cámara

    // Update is called once per frame
    void Update()
    {
        // Actualiza la posición de la cámara para que siga al jugador con un offset
        transform.position = new Vector3(
            targetPlayer.position.x + 2.1f,       // Sigue al jugador en el eje X
            targetPlayer.position.y + verticalOffset, // Añade un desplazamiento en el eje Y
            -10                                   // Mantiene la posición Z fija
        );
    }
}
