using UnityEngine;
using UnityEngine.Events;

public class ButtonTrigger : MonoBehaviour
{
    public UnityEvent onButtonLanded; // Drag the target action here in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object landing on the button is the Player
        if (other.CompareTag("Player"))
        {
            onButtonLanded.Invoke(); // Activates whatever is linked
        }
    }
}