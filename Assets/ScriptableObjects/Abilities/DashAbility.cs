using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DashAbility", menuName = "ScriptableObjects/Ability/DashAbility", order = 1)]
public class DashAbility : Ability
{
    public float distance;

    private PlayerShipMovement _playerMovement;
    protected GameObject player;

    public override void PerformAbility()
    {
        _playerMovement = SetPlayerMovement();

        Vector2 playerInput = _playerMovement.GetPlayerInput();
        if (playerInput == Vector2.zero)
            return;

        player.transform.position = new Vector3
            (player.transform.position.x + playerInput.x * distance
            , player.transform.position.y + playerInput.y * distance
            , player.transform.position.z
            );
    }

    private PlayerShipMovement SetPlayerMovement()
    {
        if (player == null) player = GameObject.FindGameObjectWithTag("Player");
        if (_playerMovement == null) return player.GetComponent<PlayerShipMovement>();
        return _playerMovement;
    }
}
