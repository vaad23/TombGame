using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] protected float Cooldown;
        [SerializeField] protected float StartTime;
        [SerializeField] protected float StopTime;

        protected float Time;
        protected bool IsActiveDamager;

        private void Update()
        {
            Timer();
        }

        protected virtual void Timer()
        {
            Time += UnityEngine.Time.deltaTime;

            if (Time > Cooldown)
            {
                Time -= Cooldown;

                if (IsActiveDamager)
                    ChangeDamager(false);
            }

            if (Time > StopTime)
            {
                if (IsActiveDamager)
                    ChangeDamager(false);
            }
            else if (Time > StartTime)
            {
                if (!IsActiveDamager)
                    ChangeDamager(true);
            }
        }

        protected virtual void ChangeDamager(bool isActive)
        {
            IsActiveDamager = isActive;
        }
    }
}
