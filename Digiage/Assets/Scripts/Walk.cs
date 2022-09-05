using UnityEngine;

public class Walk : MonoBehaviour
{
    private PlayerAnimationController playerAnimationController;
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        playerAnimationController = GetComponent<PlayerAnimationController>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        movement = new Vector2(Horizontal, Vertical);

        playerAnimationController.WalkAnimation(animator, movement);
        rb.velocity = new Vector2(movement.x * moveSpeed * Time.fixedDeltaTime, movement.y * moveSpeed * Time.fixedDeltaTime);
    }
}
