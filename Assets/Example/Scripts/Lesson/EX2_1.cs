using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2_1 : MonoBehaviour
{
    [SerializeField] private GameObject ball1;
    [SerializeField] private Rigidbody ball2;

    private void Update()
    {
        if (Input.anyKey)
        {
            ball1.transform.position += Vector3.right * 0.1f;
            ball2.velocity = Vector3.right * 50f;
        }
    }
}
