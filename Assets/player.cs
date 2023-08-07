using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float velocidade = 10;
    [SerializeField] Transform FloorCheck;
    [SerializeField] LayerMask Floor;
   
    // Start is called before the first frame update
    void Start()
    {
         rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hAxis*velocidade, rb.velocity.y);

        if (hAxis != 0) Flip(hAxis);

        if (Input.GetButtonDown("Jump") && IsOnGround()) {
            rb.velocity = new Vector2(rb.velocity.x, 20);
        }
        
    }

    bool IsOnGround() {
        return Physics2D.OverlapCircle(FloorCheck.position, 0.2f, Floor);
    }

    void Flip(float hAxis) {
        transform.localScale = new Vector2(Mathf.Sign(hAxis), transform.localScale.y);
    }
}
