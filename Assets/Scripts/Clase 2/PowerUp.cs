using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoostType 
{ 
    SPEED,
    JUMP
}

public abstract class PowerUp : MonoBehaviour
{
    public abstract void ActivatePowerUp(Player player);
    public BoostType type;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ActivatePowerUp(collision.GetComponent<Player>());
            Destroy(this.gameObject);
        }
    }
}
