using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _target;

    public bool IsMoving { get; private set; }

    private void Awake()
    {
        _target = transform.position;
    }

    private void Update()
    {
        if (IsMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

            if (transform.position == _target)
                IsMoving = false;
        }
    }

    private void Move(Vector3 target)
    {
        IsMoving = true;
        _target = target;
    }

    private void HorizontalMove(int value)
    {
        Vector3 target = _target + new Vector3(value, 0, 0);
        Move(target);
    }

    public void LeftMove(int value)
    {
        HorizontalMove(-value);
    }

    public void RightMove(int value)
    {
        HorizontalMove(value);
    }
}
