using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    [SerializeField] private float _minSpeed;
    [SerializeField] private float _distanceError;
    [SerializeField] private float _shift;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _camera;

    private float _speed;
    private float _direction;
    private float _distance;
    private float _distanceWithError;
    private Vector3 _target;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _distance = _player.position.x - (_camera.position.x + _shift);
        if (_distance + _distanceError >= 0 && _distance - _distanceError <= 0)
            return;

        _direction = (_distance - _distanceError > 0) ? -1 : 1;
        _distanceWithError = Mathf.Abs(_player.position.x + _direction * (_distanceError + _camera.position.x + _shift));
        _speed = Mathf.Clamp(_distanceWithError, _minSpeed, float.MaxValue);

        _target = new Vector3(_player.position.x + _direction * _distanceError - _shift, _camera.position.y, _camera.position.z);
        _camera.position = Vector3.MoveTowards(_camera.position, _target, _speed * Time.deltaTime);
    }
}
