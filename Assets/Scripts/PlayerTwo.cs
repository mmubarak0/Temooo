using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : PlayerOne
{
    private void Start()
    {
        PrintName();
        PlayerTwoName();
    }
    public override void PlayerTwoName()
    {
        Debug.Log("Player 2");
    }
}
