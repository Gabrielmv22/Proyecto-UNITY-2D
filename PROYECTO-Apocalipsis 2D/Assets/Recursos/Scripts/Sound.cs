using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource; // Arrastra el AudioSource desde el inspector
    public Button soundButton;      // Arrastra el botón desde el inspector

    private bool isMuted = false;

    void Start()
    {
        // Asegúrate de que el botón llame al método ToggleSound() al hacer clic
        soundButton.onClick.AddListener(ToggleSound);

        // Inicializa el estado del botón basado en el AudioSource
        UpdateButtonSprite();
    }

    public void ToggleSound()
    {
        // Alternar el estado de mute
        isMuted = !isMuted;
        audioSource.mute = isMuted;

        // Actualizar visualmente el botón
        UpdateButtonSprite();
    }

    private void UpdateButtonSprite()
{
    // Cambiar el sprite directamente en el componente Image del botón
    if (isMuted)
    {
        soundButton.image.sprite = soundButton.spriteState.disabledSprite;
    }
    else
    {
        soundButton.image.sprite = soundButton.spriteState.highlightedSprite;
    }
}

}
