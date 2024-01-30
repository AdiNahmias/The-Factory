using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the GameObject that entered the trigger zone has the name "Package"
        if (collision.gameObject.name == "Package")
        {
            // If true, call the 'CompleteGame' method
            CompleteGame();
        }
    }

    // Method to load the next scene
    private void CompleteGame()
    {
        // Load the next scene based on the build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
