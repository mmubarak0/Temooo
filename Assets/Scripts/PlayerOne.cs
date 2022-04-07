using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : PlayerBase
{
    public override void PrintName()
    {
        Debug.Log("Player 1");
    }
    public virtual void PlayerTwoName(){
        Debug.Log("Player 1 Saying Player 2 Name");
    }
}
