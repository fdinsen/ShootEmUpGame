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
    private Transform _player;
    private Collider _col;
    // Start is called before the first frame update
    void Start()
    {
        _shotsLeft = _numberOfShotsInEachVolley;
        _volleyCooldown = _cooldownBetweenVolleys;
        _shotCooldown = _shotInterval;
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _col = GetComponent<Collider>();
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
                projectile.GetComponentInChildren<Projectile>().Fire
                    (GetDirectionTowardsObject(transform.position, _player.position)
                    , 10 //Damage
                    ,_col);
            }
        }
        
    }

    Vector3 GetDirectionTowardsObject(Vector3 origin, Vector3 target)
    {
        return (target - origin).normalized;
    }
}
