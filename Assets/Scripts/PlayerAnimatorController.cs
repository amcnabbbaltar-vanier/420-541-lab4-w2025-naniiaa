using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator animator;
    private CharacterMovement movement;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Assigning the components
        animator = GetComponent<Animator>();
        movement = GetComponent<CharacterMovement>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Setting the parameters with the physics movement
        animator.SetFloat("CharacterSpeed", rb.velocity.magnitude);
        animator.SetBool("isGrounded", movement.IsGrounded);

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }
    }
}
