using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [SerializeField] private float fireSpeed = 100f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Collider col;
    [SerializeField] private float _destroyAfterSeconds = 3f;
    [SerializeField] private LayerMask _layersToTarget = new LayerMask();

    private int _damage = 0;
    
    public void Fire(Vector3 dir, int damage, Collider parentCol)
    {
        _damage = damage;
        rb.velocity = dir * fireSpeed;
        Physics.IgnoreCollision(col, parentCol);
        Destroy(gameObject, _destroyAfterSeconds);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.IsInLayerMasks(_layersToTarget)) //Check layer
        {
            other.gameObject.GetComponent<IHealthHandler>().DealDamage(_damage);
            GameObject.Destroy(gameObject);
        }

        if(other.gameObject.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        if(rb == null)
        {
            GetComponent<Rigidbody>();
        }
        if(col == null)
        {
            GetComponent<Collider>();
        }
    }
}
