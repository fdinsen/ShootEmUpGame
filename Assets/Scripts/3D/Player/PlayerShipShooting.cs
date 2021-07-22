using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerShipShooting : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private float _shootInterval = 0.1f;
    [SerializeField] private Transform _fireFrom;

    private PlayerInput _playerInput;
    private bool _primaryHeld = false;

    // Start is called before the first frame update
    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();

        _playerInput.CombatMovement.PrimaryAttack.started += ctx => BeginShooting();
        _playerInput.CombatMovement.PrimaryAttack.canceled += ctx => EndShooting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BeginShooting()
    {
        _primaryHeld = true;
        StartCoroutine(PerformShooting());
    }
    void EndShooting()
    {
        _primaryHeld = false;
    }

    IEnumerator PerformShooting()
    {
        while(_primaryHeld)
        {
            ShootProjectile(transform.right);
            yield return new WaitForSeconds(_shootInterval);
        }
    }

    void ShootProjectile(Vector3 dir)
    {
        var projectile = Instantiate(_projectile, _fireFrom.position, transform.rotation) as GameObject;
        projectile.GetComponentInChildren<Projectile>().Fire(dir);
    }
}
