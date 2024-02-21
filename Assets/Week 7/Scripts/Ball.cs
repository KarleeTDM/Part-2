using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void ResetBallPosition()
    {
        Debug.Log("Resetting the position!");
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
    }
}
