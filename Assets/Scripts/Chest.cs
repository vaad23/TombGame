using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : TrackingPlayer
{
    protected override void Find(Player player)
    {
        player.TrafficBan(true);
        base.Find(player);
    }
}
