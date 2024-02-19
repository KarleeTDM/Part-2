using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAssignment : MonoBehaviour // F in the chat for this not going into the project because no dynamic Rigidbody2Ds allowed. 😔
{
    Rigidbody2D rb;
    public float speed = 100f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rb.MovePosition(rb.position - direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected.");
        Destroy(gameObject);
    }
}
