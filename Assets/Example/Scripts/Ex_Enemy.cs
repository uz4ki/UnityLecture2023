using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Enemy : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    private float _timer;
    private bool _isInsideCamera;
    private bool _isWalking;

    public float speed;
    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 0.5f)
        {
            _timer -= 0.5f;
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }

        if (!_isWalking && _isInsideCamera)
        {
            _isWalking = true;
            _rb.velocity = Vector2.left * speed; 
        }
    }
    
    private void OnBecameVisible() {
        _isInsideCamera = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            var player = col.gameObject.GetComponent<Rigidbody2D>();
            player.velocity = new Vector2(player.velocity.x, 8f);
            Destroy(gameObject);
        }
    }
}
