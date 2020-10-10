using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMove))]
public class PlayerMaster : MonoBehaviour
{
    public PlayerAnimation playerAnimation;
    public PlayerMove playerMove;

    private void OnEnable()
    {
        //playerAnimation = GetComponent<PlayerAnimation>();
        playerMove = GetComponent<PlayerMove>();
    }
}

