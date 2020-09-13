using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class CannonMechanism : Obstacle
    {
        [SerializeField] private float _startTime;
        [SerializeField] private float _stopTime;
        [SerializeField] private Damager _damager;

        private float _time;
        private bool _isActiveDamager;

        private void Update()
        {
            _time += Time.deltaTime;

            if (_time > Cooldown)
                _time -= Cooldown;

            if (_time > _stopTime)
            {
                if (_isActiveDamager)
                    ChangeDamager(false);
            }
            else if (_time > _startTime)
            {
                if (!_isActiveDamager)
                    ChangeDamager(true);
            }
        }

        private void ChangeDamager(bool isActive)
        {
            _isActiveDamager = isActive;
            _damager.gameObject.SetActive(isActive);
        }

    }
}
