using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public enum Direction
    {
        Left = 0,
        Right = 1
    }

    [SerializeField] private TrackingMouseClick _leftArea;
    [SerializeField] private TrackingMouseClick _rightArea;

    public event UnityAction<Direction> OccurredInput;

    private void OnEnable()
    {
        _leftArea.Clicked += LeftInput;
        _rightArea.Clicked += RightInput;
    }

    private void OnDisable()
    {
        _leftArea.Clicked -= LeftInput;
        _rightArea.Clicked -= RightInput;
    }

    private void Update()
    {
        if (Input.anyKeyDown)
            InputValidation();
    }

    private void InputValidation()
    {
        if (Input.GetKeyDown(KeyCode.A))
            LeftInput();

        if (Input.GetKeyDown(KeyCode.D))
            RightInput();
    }

    private void LeftInput()
    {
        OccurredInput?.Invoke(Direction.Left);
    }

    private void RightInput()
    {
        OccurredInput?.Invoke(Direction.Right);
    }
}
