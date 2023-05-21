using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Flag : MonoBehaviour
{
    private Ex_GameManager _exGameManager;

    private void Start()
    {
        _exGameManager = GameObject.Find("GameManager").GetComponent<Ex_GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            _exGameManager.GameClear();
        }
    }
}
