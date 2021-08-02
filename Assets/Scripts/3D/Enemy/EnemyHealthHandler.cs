using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthHandler : MonoBehaviour, IHealthHandler
{
    [SerializeField] private int _health = 100;
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private float _destroyAfterSeconds = 1f;

    private FlashHandler _flasher;

    void Start()
    {
        TryGetComponent(out _flasher);
    }

    public void DealDamage(int damage)
    {
        _health -= damage;
        _flasher?.Flash(); //if GameObject has an FlashHandler Component, do flash
        if (_health <= 0)
        {
            Die();
        }
    }

    public void HealHealth(int healBy)
    {
        Mathf.Clamp(
            (_health += healBy), 0, _maxHealth);
    }

    public void Die()
    {
        Destroy(gameObject, _destroyAfterSeconds);
    }


}
