using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerShipShooting : MonoBehaviour
{
    [SerializeField] private ShootingAction _primaryShooting;

    private PlayerInput _playerInput;
    private bool _primaryHeld = false;
    private Collider _shipCollider;

    // Start is called before the first frame update
    void Awake()
    {
        _shipCollider = GetComponentInParent<Collider>();
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();

        _playerInput.CombatMovement.PrimaryAttack.started += ctx => BeginShooting();
        _playerInput.CombatMovement.PrimaryAttack.canceled += ctx => EndShooting();
    }
    void OnDisable()
    {
        _playerInput.CombatMovement.Disable();
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
            _primaryShooting.Shoot(transform.right, _shipCollider);
            yield return new WaitForSeconds(_primaryShooting.GetShootInterval());
        }
    }
}
