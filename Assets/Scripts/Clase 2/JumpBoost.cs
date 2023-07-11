using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : PowerUp
{
    public float boostAmount = 1.5f;
    public float duration = 5.0f;

    public override void ActivatePowerUp(Player player)
    {
        player.jumpForce += boostAmount;
        player.ResetBoost(type, duration, boostAmount);
    }
}
