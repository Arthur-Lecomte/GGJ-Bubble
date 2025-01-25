using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float walkSpeed = 2f;       // Vitesse de déplacement
    public float jumpForce = 5f;       // Force du saut
    public float groundCheckDistance = 1f; // Distance pour vérifier si le mouton touche le sol

    private Rigidbody rb;
    private Animator animator;
    private bool isGrounded = true;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);
        Debug.Log(isGrounded);

        animator.SetTrigger("Walk");
        transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
        if(!isGrounded)
        {
            animator.SetTrigger("Jump");
            animator.SetTrigger("Fall");
        }
        if (isGrounded)
        {
            animator.ResetTrigger("Jump");
            animator.ResetTrigger("Fall");
        }
    }
}
