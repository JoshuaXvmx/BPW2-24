using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 playerInput;
    private Rigidbody2D rb;
    public SpriteRenderer spriteRenderer; // Public SpriteRenderer

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = playerInput.normalized * moveSpeed;

        // Flip the sprite based on horizontal movement
        if (playerInput.x > 0) // Moving right
        {
            spriteRenderer.flipX = true; // Don't flip (face right)
        }
        else if (playerInput.x < 0) // Moving left
        {
            spriteRenderer.flipX = false; // Flip horizontally (face left)
        }
        //If the player input is 0, the player is not moving horizontally, and thus should keep the previous direction.
    }
}
