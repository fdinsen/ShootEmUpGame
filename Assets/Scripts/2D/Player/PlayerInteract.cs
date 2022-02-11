using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private PlayerInput _playerInput;

    [SerializeField] private LayerMask interactableLayers = new LayerMask();

    // Start is called before the first frame update
    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Disable();
        _playerInput._2DMovement.Enable();

        _playerInput._2DMovement.Interact.performed += ctx => Interact();
        PlayerMovement.ToggleMovement += ToggleInteract;
    }
    void OnDisable()
    {
        _playerInput._2DMovement.Disable();
    }

    // Update is called once per frame
    void Interact()
    {
        var interacted = Physics.OverlapSphere(transform.position, 1f, interactableLayers);
        foreach(Collider col in interacted)
        {
            col.GetComponent<IInteractable>().Interact();
        }
    }

    void ToggleInteract(bool toEnable)
    {
        if (toEnable)
        {
            _playerInput._2DMovement.Enable();
        }
        else
        {
            _playerInput._2DMovement.Disable();
        }
    }
}
