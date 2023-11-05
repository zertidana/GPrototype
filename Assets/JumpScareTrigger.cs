using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareTrigger : MonoBehaviour
{
    public GameObject zombieModel;
    public AudioSource screamAudio;
    public float disappearDelay = 2.0f;

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            // Activate the zombie model
            zombieModel.SetActive(true);

            // Play the scream audio
            screamAudio.Play();

            // Set the trigger flag to prevent repeated triggers
            hasTriggered = true;

            // Schedule the zombie to disappear after the specified delay
            Invoke("DisappearZombie", disappearDelay);
        }
    }

    private void DisappearZombie()
    {
        // Deactivate the zombie model
        zombieModel.SetActive(false);
    }
}
