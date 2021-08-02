using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthHandler : MonoBehaviour, IHealthHandler
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _invincibilityTime = 0.1f;
    [SerializeField] private bool _invincibilityTransparency;

    private FlashHandler _flasher;
    private float _invincibilityCountdown = 0f;
    private MeshRenderer _renderer;

    void Start()
    {
        GetComponentInChildren<MeshRenderer>();
        TryGetComponent(out _flasher);
    }

    public void DealDamage(int damage)
    {
        if(_invincibilityCountdown <= 0.0f)
        {
            _health -= damage;
            _invincibilityCountdown = _invincibilityTime;
            _flasher?.Flash(); //if GameObject has an FlashHandler Component, do flash
            if (_health <= 0)
            {
                Die();
            }
        }  
        
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void HealHealth(int healBy)
    {
        Mathf.Clamp(
            (_health += healBy), 0 ,_maxHealth);
    }

    void Update()
    {
        if(_invincibilityCountdown > 0.0f)
        {
            _invincibilityCountdown -= Time.deltaTime;
        }
    }

    IEnumerator MakeObjectTransparent()
    {
        //_renderer.material.color = ;
        yield return new WaitForSeconds(_invincibilityTime);
    }
}
