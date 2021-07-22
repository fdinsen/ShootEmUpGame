using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [SerializeField] private float fireSpeed = 5f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float _destroyAfterSeconds = 3f;
    
    public void Fire(Vector3 dir)
    {
        rb.velocity = dir * fireSpeed;
        Destroy(gameObject, _destroyAfterSeconds);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
