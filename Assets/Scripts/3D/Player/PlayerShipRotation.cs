using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipRotation : MonoBehaviour
{
    [SerializeField] private Transform _crosshair;

    private PlayerInput _playerInput;

    // Start is called before the first frame update
    void Start()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();
        _crosshair.parent = null;
    }

    void OnDisable()
    {
        _playerInput.CombatMovement.Disable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RotateTowardsMousePointer();
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
}
