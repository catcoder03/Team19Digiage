using UnityEngine;

public class MouseAttack : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator attackAnimator;
    public Camera camera;
    private PlayerAnimationController playerAnimationController;

    Vector2 mousePos;

    private void Awake()
    {
        playerAnimationController = GetComponent<PlayerAnimationController>();
        rb = GetComponent<Rigidbody2D>();
        attackAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - rb.position;
        lookDir.Normalize();

        playerAnimationController.AttackAnimation(attackAnimator, lookDir);
    }
}