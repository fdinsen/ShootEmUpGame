using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{
    [SerializeField] private Transform _shipModel;
    [SerializeField] private Transform _crosshair;
    [SerializeField] private float _moveSpeed = 1f;

    private PlayerInput _playerInput;

    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();
        _crosshair.parent = null;
    }

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        MovePlayer();
        RotateTowardsMousePointer();
    }

    private void MovePlayer()
    {
        var input = _playerInput.CombatMovement.Movement.ReadValue<Vector2>();
        if (input.magnitude > 0.0f)
        {
            transform.position += new Vector3(input.x, input.y, 0.0f) * _moveSpeed;
        }
    }

    private void RotateTowardsMousePointer()
    {
        Vector2 mouse = _playerInput.CombatMovement.Mouse.ReadValue<Vector2>();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, Mathf.Abs(Camera.main.transform.position.z)));

        if (_crosshair != null)
            _crosshair.position = mouseWorld;

        Vector3 aimDirection = (mouseWorld - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    //private Vector3  
}
