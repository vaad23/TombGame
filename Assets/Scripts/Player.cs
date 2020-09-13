using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private PlayerMover _mover;

    private void OnEnable()
    {
        _input.OccurredInput += InputValidation;
    }

    private void OnDisable()
    {
        _input.OccurredInput -= InputValidation;
    }

    private void Start()
    {

    }

    private void InputValidation(PlayerInput.Direction direction)
    {
        switch (direction)
        {
            case PlayerInput.Direction.Left:
                _mover.LeftMove(1);
                break;
            case PlayerInput.Direction.Right:
                _mover.RightMove(1);
                break;
        }
    }

    public void TakeDamage()
    {
        Debug.Log("Take Damage");
    }
}
