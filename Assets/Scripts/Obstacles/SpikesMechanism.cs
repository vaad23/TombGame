using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class SpikesMechanism : Obstacle
    {
        [SerializeField] private Damager _damager;

        protected override void ChangeDamager(bool isActive)
        {
            base.ChangeDamager(isActive);
            _damager.gameObject.SetActive(isActive);
        }
    }
}
