using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 7.5f;
    public float jumpForce = 5.0f;
    [SerializeField] private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();    
    }

    public void ResetBoost(BoostType type, float duration, float boostAmount) 
    {
        StartCoroutine(ResetState(type, duration, boostAmount));
    }

    private IEnumerator ResetState(BoostType type, float duration, float boostAmount)
    {
        yield return new WaitForSeconds(duration);
        switch (type)
        {
            case BoostType.JUMP:
                jumpForce -= boostAmount;
                break;
            case BoostType.SPEED:
                speed /= boostAmount;
                break;
        }
    }

    private void Update()
    {
        Move();
        if (Input.GetButtonDown("Jump")) 
        {
            Jump();
        }
    }

    private void Move()
    {
        float move = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(move * speed, _rb.velocity.y);
    }

    private void Jump() 
    {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}