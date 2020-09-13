using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private PlayerMover _mover;

    private void Start()
    {
        _mover.RightMove(3);
    }

    public void TakeDamage()
    {
        Debug.Log("Take Damage");
    }
}
