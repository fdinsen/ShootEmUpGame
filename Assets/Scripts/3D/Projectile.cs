using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [SerializeField] private float fireSpeed = 5f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float _destroyAfterSeconds = 3f;

    private int _damage = 0;
    
    public void Fire(Vector3 dir, int damage)
    {
        _damage = damage;
        rb.velocity = dir * fireSpeed;
        Destroy(gameObject, _destroyAfterSeconds);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 3 ) //Enemy
        {
            other.gameObject.GetComponent<IHealthHandler>().DealDamage(_damage);
        }
    }

}
