using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbilityAction : AbilityAction
{
    [SerializeField] private float _dashDistance = 10f;
    [SerializeField] private Transform _ship;

    private PlayerShipMovement _playerMovement;
    

    public override void PerformAbility()
    {
        Vector2 playerInput = _playerMovement.GetPlayerInput();
        _ship.position = new Vector3(transform.position.x + playerInput.x * _dashDistance, transform.position.y + playerInput.y * _dashDistance, transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponentInParent<PlayerShipMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
