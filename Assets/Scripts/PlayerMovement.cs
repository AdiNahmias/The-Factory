using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

// Require Rigidbody2D component to be attached to the same GameObject
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private BoxCollider2D coll; // Reference to the BoxCollider2D component
    private Animator anim; // Reference to the Animator component

    private float DirX = 0f; // Horizontal input direction
    private float DirY = 0f; // Vertical input direction
    [SerializeField] private float stepSize = 7f; // Movement speed
    [SerializeField] private float jumpSize = 14f; // Jump force

    

    public bool ClimbingAllow { get; set; } // Boolean flag for climbing state

    [SerializeField] InputAction jump = new InputAction(type: InputActionType.Button); // Jump input action

    [SerializeField] private LayerMask jumpableGround; // Layer mask for detecting jumpable ground
    [SerializeField] private LayerMask jumpableBox; // Layer mask for detecting jumpable boxes

    private enum MovementState { Idle, Running, Jumping, Falling } // Enum for player movement states

    void OnEnable()
    {
        jump.Enable(); // Enable the jump input action
    }

    void OnDisable()
    {
        jump.Disable(); // Disable the jump input action
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Assign the Rigidbody2D component
        coll = GetComponent<BoxCollider2D>(); // Assign the BoxCollider2D component
        anim = GetComponent<Animator>(); // Assign the Animator component
    }

    // Update is called once per frame
    void Update()
    {
        DirX = Input.GetAxisRaw("Horizontal"); // Get horizontal input
        rb.velocity = new Vector2(DirX * stepSize, rb.velocity.y); // Update horizontal velocity

        // Check for jump input and conditions for jumping
        if (jump.WasPressedThisFrame() && (IsGrounded() || IsOnBox()))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSize, 0); // Apply jump force
        }

        UpdateAnimationState(); // Update player animation state

        // Check if climbing is allowed and update vertical velocity
        if (ClimbingAllow)
        {
            DirY = Input.GetAxisRaw("Vertical") * stepSize;
        }
    }

    private void FixedUpdate()
    {
        // Update rigidbody properties based on climbing state
        if (ClimbingAllow)
        {
            rb.isKinematic = true;
            rb.velocity = new Vector2(DirX * stepSize, DirY);
        }
        else
        {
            rb.isKinematic = false;
            rb.velocity = new Vector2(DirX * stepSize, rb.velocity.y);
        }
    }

    // Update player animation state based on input and velocity
    private void UpdateAnimationState()
    {
        MovementState state;

        bool DirXHigherThenZero = (DirX > 0); //checking if we moving right

        bool DirXLowerThenZero = (DirX < 0); // checking if we moving left

        bool IsJumping = (rb.velocity.y > 0.1f);  // checking if we jumping

        bool IsFalling = (rb.velocity.y < -0.1f); // checking if we falling

        // Running animation when moving and idle when not
        if (DirXHigherThenZero)
        {
            state = MovementState.Running;
            transform.rotation = Quaternion.identity; // Reset rotation when facing right
        }
        else if (DirXLowerThenZero)
        {
            state = MovementState.Running;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f); // Rotate 180 degrees when facing left
        }
        else
        {
            state = MovementState.Idle;
        }

        // Update animation state based on vertical velocity
        if (IsJumping)
        {
            state = MovementState.Jumping;
        }
        else if (IsFalling)
        {
            state = MovementState.Falling;
        }

        anim.SetInteger("state", (int)state); // Set animation parameter
    }

    // Check if the player is grounded
    // This function is used to detect collisions or intersections between a box-shaped area and other objects in the 2D world
    private bool IsGrounded()
    {
        float NoAngle = 0f;

        float Dist = 0.1f;

        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, NoAngle, Vector2.down, Dist, jumpableGround);
    }

    // Check if the player is on a box
    // This function is used to detect collisions or intersections between a box-shaped area and other objects in the 2D world
    private bool IsOnBox()
    {
        float NoAngle = 0f;

        float Dist = 0.1f;
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, NoAngle, Vector2.down, Dist, jumpableBox);
    }
}
