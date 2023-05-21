using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Block : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D col)
    {
        Destroy(gameObject);
    }
}
