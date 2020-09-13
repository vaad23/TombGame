using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class Damager : TrackingPlayer
    {
        protected override void Find(Player player)
        {
            player.TakeDamage();
        }
    }
}
