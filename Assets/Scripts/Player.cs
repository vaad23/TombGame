using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private PlayerMover _mover;
    [SerializeField] private Collider _collider;
    [SerializeField] private UnityEvent _died;

    private bool isTrafficBan;

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
        if (isTrafficBan)
            return;

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
        TrafficBan(true);
        _died?.Invoke();
    }

    public void TrafficBan(bool isBan)
    {
        isTrafficBan = isBan;
        _collider.enabled = !isBan;
        _mover.StopMove();
    }
}
