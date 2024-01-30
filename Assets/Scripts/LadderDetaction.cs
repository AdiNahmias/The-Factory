using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderDetaction : MonoBehaviour
{
    [SerializeField] private PlayerMovement player; // Reference to the PlayerMovement script attached to the player GameObject

    // Called when another Collider2D enters the trigger zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding GameObject has a Ladder component
        if (collision.GetComponent<Ladder>())
        {
            // If true, allow the player to climb by setting ClimbingAllow to true in the PlayerMovement script
            player.ClimbingAllow = true;
        }
    }

    // Called when another Collider2D exits the trigger zone
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Check if the colliding GameObject has a Ladder component
        if (collision.GetComponent<Ladder>())
        {
            // If true, disable climbing by setting ClimbingAllow to false in the PlayerMovement script
            player.ClimbingAllow = false;
        }
    }
}
