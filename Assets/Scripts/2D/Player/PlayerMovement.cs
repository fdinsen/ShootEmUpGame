using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.1f;

    public delegate void ToggleMovementEvent(bool toggleOn);
    public static event ToggleMovementEvent ToggleMovement;

    private PlayerInput _playerInput;
    private Animator _anim;
    private CharacterController _charContr;
    private Vector3 moveBy;

    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Disable();
        _playerInput._2DMovement.Enable();
        _charContr = GetComponent<CharacterController>();
        _anim = GetComponent<Animator>();
        moveBy = new Vector3();

        ToggleMovement += ToggleMovement;
    }
    void OnDisable()
    {
        _playerInput._2DMovement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        var input = _playerInput._2DMovement.Movement.ReadValue<Vector2>();

        moveBy.x = input.x;
        moveBy.z = input.y;

        if (moveBy != Vector3.zero)
        {
            _anim.SetFloat("YSpeed", moveBy.normalized.z);
            _anim.SetFloat("XSpeed", moveBy.normalized.x);
        }

        _anim.SetFloat("Speed", moveBy.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        _charContr.SimpleMove(moveBy * _moveSpeed);
    }

    public void TogglePlayerMovement(bool toEnable)
    {
        if(toEnable)
        {
            _playerInput._2DMovement.Enable();
        } else
        {
            _playerInput._2DMovement.Disable();
        }
    }

    public static void InvokeToggleMovement(bool toggleOn)
    {
        ToggleMovement.Invoke(toggleOn);
    }
}
