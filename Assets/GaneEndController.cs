using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YouWinTrigger : MonoBehaviour
{
    public TextMeshProUGUI winMessage;

    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasWon)
        {
            // Display "YOU WIN" message
            winMessage.enabled = true;
            hasWon = true;
        }
    }
}








