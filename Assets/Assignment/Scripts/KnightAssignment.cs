using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAssignment : MonoBehaviour // Now with comments! :D
{
    // important variables here
    Rigidbody2D rb;
    Animator animator;
    Vector2 destination;
    Vector2 movement;
    public float speed = 3;
    bool clickingOnSelf = false;
    public int health;
    public int maxHealth = 5;
    bool isDead = false;
    public HealthBar healthBar;
    public AnimationCurve dead;
    float deathTimer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = PlayerPrefs.GetInt("KnightHealth", 5);
        SendMessage("SetInitialHealth", health);
    }

    private void FixedUpdate()
    {
        if (isDead)
        {
            deathTimer += 0.1f * Time.deltaTime;
            float timing = dead.Evaluate(deathTimer);
            if (transform.localScale.z < 0f)
            {
                return;
            }
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, timing); // shrink to the size of an ant LOL
            float angle = Mathf.Atan2(destination.x, destination.y) * Mathf.Rad2Deg; // obvi not on my planning but oh well
            rb.rotation = -angle; // adding this because 1) it was one of my tasks and 2) the knight just wants to be silly :P
        }
        if (!isDead)
        {
            deathTimer = 0;
            movement = destination - (Vector2)transform.position;
            if (movement.magnitude < 0.1)
            {
                movement = Vector2.zero;
            }
            rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
        }   
    }

    void Update()
    {
        if (isDead) return;
        if (Input.GetMouseButtonDown(0) && !clickingOnSelf && !EventSystem.current.IsPointerOverGameObject())
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("Movement", movement.magnitude);
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("Attack");
        }
    }

    private void OnMouseDown()
    {
        if (isDead) return;
        clickingOnSelf = true;
        SendMessage("TakeDamage", 1);
    }

    private void OnMouseUp()
    {
        clickingOnSelf = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SendMessage("TakeDamage", 1);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);
        PlayerPrefs.SetInt("KnightHealth", health);
        if (health <= 0)
        {
            isDead = true;
            animator.SetTrigger("Death");
        }
        else
        {
            isDead = false;
            animator.SetTrigger("TakeDamage");
            transform.localScale = Vector3.one;
            destination = Vector2.zero;
        }
    }

    public void SetInitialHealth(int HP)
    {
        health = HP;
    }
}
