using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;


public class PlayerController : MonoBehaviour
{
    public Collider2D attackCollider;
    public Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveDirection;
    [SerializeField] private InputActionReference move;
    [SerializeField] private InputActionReference attack;
    [SerializeField] private InputActionReference jump;
    private bool isAttacking = false;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    private bool isJumping;
    [SerializeField] private float jumpForce;

    private void Update()
    {
        moveDirection = move.action.ReadValue<Vector2>();
        // Flip the sprite based on the direction of movement
        if (moveDirection.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveDirection.x > 0)
        {
            spriteRenderer.flipX = false;
        }

        // Set isRunning to true if the player is moving, false otherwise
        if (Mathf.Abs(moveDirection.x) > 0.01f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);
    }

    private void OnEnable()
    {
        attack.action.started += Attack;
        jump.action.started += Jump;
    }

    private void OnDisable()
    {
        attack.action.started -= Attack;
        jump.action.started -= Jump;
    }

    private void Attack(InputAction.CallbackContext context)
    {
        if (!isAttacking)
        {
            isAttacking = true;
            animator.SetBool("isAttacking", true);
            StartCoroutine(ResetAttackAfterAnimation());
        }
    }


    private IEnumerator ResetAttackAfterAnimation()
    {
        float animationLength = animator.runtimeAnimatorController.animationClips.FirstOrDefault(clip => clip.name == "HomelessAttackAnim")?.length ?? 0;

        yield return new WaitForSeconds(animationLength);

        isAttacking = false;
        animator.SetBool("isAttacking", false);
    }

    private void Jump(InputAction.CallbackContext context)
    {
        if (!isJumping)
        {
            isJumping = true;
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            animator.SetBool("isJumping", isJumping);
            StartCoroutine(ResetJumpAfterAnimation());
        }
    }

    private IEnumerator ResetJumpAfterAnimation()
    {
        float animationLength = animator.runtimeAnimatorController.animationClips.FirstOrDefault(clip => clip.name == "HomelessJumpAnim")?.length ?? 0;

        yield return new WaitForSeconds(animationLength);

        isJumping = false;
        animator.SetBool("isJumping", false);
    }
}