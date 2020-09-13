using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Transform _startPosition;
        [SerializeField] private Transform _target;

        private void Awake()
        {
            StartMove();
        }

        private void Update()
        {
            Move();                
        }

        private void Move()
        {
            if (transform.position == _target.position)
                return;

            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        }

        public void StartMove()
        {
            transform.position = _startPosition.position;
        }
    }
}
