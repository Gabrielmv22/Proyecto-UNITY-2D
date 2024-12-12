using UnityEngine;

public class AparicionJugador : MonoBehaviour
{
    [SerializeField] private GameObject targetObject; // Objeto a activar
    [SerializeField] private float delay = 1f; // Tiempo de espera en segundos

    void Start()
    {
        // Llamamos a la función para activar el objeto después de un tiempo
        Invoke("ActivateObject", delay);
    }

    void ActivateObject()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true); // Activa el objeto
        }
        else
        {
            Debug.LogWarning("No se asignó el objeto a activar.");
        }
    }
}
