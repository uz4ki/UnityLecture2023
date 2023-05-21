using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Player : MonoBehaviour
{
    public float jumpPower;
    public float walkSpeed;


    private Rigidbody2D _rb;
    public Ex_GameManager exGameManager;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2f)
        {
            exGameManager.GameOver();
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            var isGround = Physics2D.Raycast((Vector2)transform.position + Vector2.down * 0.51f, Vector2.down, 0.05f);
            if (!isGround) return;
            _rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }

        var xVector = 0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xVector += 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xVector -= 1f;
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            xVector *= 2f;
        }
        
        _rb.velocity = Vector2.right * xVector * walkSpeed + Vector2.up * _rb.velocity.y;
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            exGameManager.GameOver();
        }
    }
}
