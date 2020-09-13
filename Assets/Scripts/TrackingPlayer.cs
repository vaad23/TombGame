using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrackingPlayer : MonoBehaviour
{
    [SerializeField] protected UnityEvent _finded;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
            Find(player);
    }

    protected virtual void Find(Player player)
    {
        _finded?.Invoke();
    }
}
