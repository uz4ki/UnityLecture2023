using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_CoinBlock : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite doneSprite;
    private Ex_GameManager _exGameManager;

    private bool _isUsed;

    private void Start()
    {
        _exGameManager = GameObject.Find("GameManager").GetComponent<Ex_GameManager>();
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(_isUsed) return;
        _isUsed = true;
        _exGameManager.coinNum++;
        spriteRenderer.sprite = doneSprite;
    }
}
