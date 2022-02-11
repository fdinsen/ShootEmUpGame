using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private PlayerInput _playerInput;

    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();
    }

    void OnDisable()
    {
        _playerInput.CombatMovement.Disable();
    }

    // FixedUpdate is called 50 times per second
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        var input = _playerInput.CombatMovement.Movement.ReadValue<Vector2>();
        if (input.magnitude > 0.0f)
        {
            transform.position += new Vector3(input.x, input.y, 0.0f) * _moveSpeed * Time.deltaTime;
        }
    }
    public Vector2 GetPlayerInput()
    {
        return _playerInput.CombatMovement.Movement.ReadValue<Vector2>();
    }
}
