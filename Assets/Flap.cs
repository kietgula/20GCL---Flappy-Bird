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
        var reMapResult = rb.velocity.y * 90f/20f;
        Debug.Log(reMapResult);
        this.transform.rotation = Quaternion.Euler(0f, 0f, reMapResult);
    }
}
