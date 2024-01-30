using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;  // Reference to the player GameObject position

    // Update is called once per frame
    void Update()
    {
        // this make the camera follow the player position 
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
