using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerShipShooting))]
public abstract class ShootingAction : MonoBehaviour
{
    [SerializeField] protected GameObject _projectile;
    [SerializeField] protected float _shootInterval = 0.1f;
    [SerializeField] protected Transform[] _fireFrom;

    public abstract void Shoot(Vector3 dir);

    public float GetShootInterval()
    {
        return _shootInterval;
    }
}
