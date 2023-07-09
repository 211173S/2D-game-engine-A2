using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isPressJump = false;
    public float moveSpeed;
    [HideInInspector] public Rigidbody2D rb;
    public Vector2 moveDir;
    [HideInInspector]
    public float lastHorizontal;
    [HideInInspector]
    public float lastVertical;
    [SerializeField] public float jumpForce; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();    
    }
    void Update()
    {
        InputManagement();  
    }
    void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        moveDir = new Vector2(moveX, 0).normalized;
        if (moveDir.x != 0)
        {
            lastHorizontal = moveDir.x;
        }
        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            isPressJump = true;
            rb.AddForce(Vector2.up * jumpForce * 5);
        }
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
