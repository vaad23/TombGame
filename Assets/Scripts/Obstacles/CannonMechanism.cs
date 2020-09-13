using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class CannonMechanism : Obstacle
    {
        [SerializeField] private Mover _mover;

        protected override void ChangeDamager(bool isActive)
        {
            base.ChangeDamager(isActive);
            _mover.gameObject.SetActive(isActive);
            _mover.StartMove();
        }

    }
}
