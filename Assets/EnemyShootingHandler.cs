using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingHandler : MonoBehaviour
{
    [SerializeField] private float _shotInterval = .5f;
    [SerializeField] private int _numberOfShotsInEachVolley = 5;
    [SerializeField] private float _cooldownBetweenVolleys = 5;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _fireFrom;

    private int _shotsLeft;
    private float _volleyCooldown;
    private float _shotCooldown;
    // Start is called before the first frame update
    void Start()
    {
        _shotsLeft = _numberOfShotsInEachVolley;
        _volleyCooldown = _cooldownBetweenVolleys;
        _shotCooldown = _shotInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if(_shotsLeft == 0) 
        {
            _volleyCooldown -= Time.deltaTime;
            if (_volleyCooldown <= 0)
            {
                _shotsLeft = _numberOfShotsInEachVolley;
                _volleyCooldown = _cooldownBetweenVolleys;
            }
        }else
        {
            _shotCooldown -= Time.deltaTime;
            if(_shotCooldown <= 0)
            {
                _shotCooldown = _shotInterval;
                _shotsLeft--;

                var projectile = Instantiate(_projectile, _fireFrom.position, transform.rotation) as GameObject;
                projectile.GetComponentInChildren<Projectile>().Fire(transform.right, 10);
            }
        }
        
    }
}
