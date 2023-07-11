using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 1f;
    private Transform _player;
    private Transform originalParent;

    private void Update()
    {
        float t = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector2.Lerp(pointA.position, pointB.position, t);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            originalParent = collision.transform.parent;
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(originalParent);
        }
    }
}
