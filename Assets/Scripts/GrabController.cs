using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabController : MonoBehaviour
{
    [SerializeField] private Transform grabPoint; // Reference to the point where the object is grabbed
    [SerializeField] private Transform rayPoint; // Reference to the point where the ray is cast from
    [SerializeField] private float rayDist; // The distance of the ray

    private GameObject grabbedObject; // Reference to the currently grabbed object
    private int layerPackage; // Layer index used for raycasting
    private int layerBox; // Layer index used for raycasting

    private void Start()
    {
        layerPackage = LayerMask.NameToLayer("Object"); // Set the layer index for raycasting
        layerBox = LayerMask.NameToLayer("Box"); // Set the layer index for raycasting
    }

    // Update is called once per frame
    void Update()
    {
        // Cast a 2D ray from rayPoint towards grabPoint with a maximum distance of rayDist
        RaycastHit2D grabCheck = Physics2D.Raycast(rayPoint.position, grabPoint.localPosition, rayDist);

        // Check if the ray hits an object on the specified layer
        if (grabCheck.collider != null && grabCheck.collider.gameObject.layer == layerPackage || grabCheck.collider != null && grabCheck.collider.gameObject.layer == layerBox)
        {
            // Check if the grab key (F key) was pressed this frame and no object is currently grabbed
            if (Keyboard.current.fKey.wasPressedThisFrame && grabbedObject == null)
            {
                // Set the grabbed object, make it kinematic, set its position to grabPoint, and set it as a child of this object
                grabbedObject = grabCheck.collider.gameObject;
                grabbedObject.GetComponent<Rigidbody2D>().isKinematic = true;
                grabbedObject.transform.position = grabPoint.position;
                grabbedObject.transform.SetParent(transform);
            }
            // Check if the grab key (F key) was pressed this frame and an object is currently grabbed
            else if (grabbedObject != null && Keyboard.current.fKey.wasPressedThisFrame)
            {
                // Release the grabbed object by making it non-kinematic, removing its parent, and resetting grabbedObject to null
                grabbedObject.GetComponent<Rigidbody2D>().isKinematic = false;
                grabbedObject.transform.SetParent(null);
                grabbedObject = null;
            }
        }
    }
}
