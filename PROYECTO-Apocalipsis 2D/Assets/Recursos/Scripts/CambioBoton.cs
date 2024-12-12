using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Necesario para los eventos de interacción
using System.Collections;

public class HoldButtonWithDelay : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Text texto1; // Referencia al texto1
    public Text texto2; // Referencia al texto2
    public float delay = 0.25f; // Duración del delay en segundos

    private bool isButtonPressed = false; // Bandera para saber si el botón está pulsado

    // Evento cuando el botón está presionado
    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonPressed = true; // Marca el botón como pulsado
        texto1.gameObject.SetActive(false); // Desactiva texto1
        texto2.gameObject.SetActive(true);  // Activa texto2
    }

    // Evento cuando se suelta el botón
    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonPressed = false; // Marca el botón como no pulsado
        // Inicia la corrutina para regresar al texto1 después del delay
        StartCoroutine(RegresarTexto1ConDelay());
    }

    // Corrutina que espera el delay antes de activar texto1
    private IEnumerator RegresarTexto1ConDelay()
    {
        yield return new WaitForSeconds(delay); // Espera el tiempo del delay

        // Verifica que el botón ya no esté pulsado antes de cambiar los textos
        if (!isButtonPressed)
        {
            texto1.gameObject.SetActive(true);  // Activa texto1
            texto2.gameObject.SetActive(false); // Desactiva texto2
        }
    }
}


