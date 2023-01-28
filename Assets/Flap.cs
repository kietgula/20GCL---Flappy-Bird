using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{
    public float jumpForce = 5;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        //* in spite of using FixedUpdate for physic moves such as Rigidbody,AddForce is recommended, ForceMode.Impulse (included 2D) is better using in Update as it is not depend on Time :D . Same for Raycastings
        // if (isJumping)
        // {
        //     rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
        //     isJumping = false;
        // }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Game Over");
    }
}
