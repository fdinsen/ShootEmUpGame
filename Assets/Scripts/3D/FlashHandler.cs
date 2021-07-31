using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashHandler : MonoBehaviour
{
    [SerializeField] private float flashTime = 0.01f;
    [SerializeField] private Color _flashColour;
    private Color origionalColour;
    
    private MeshRenderer _renderer;
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        origionalColour = _renderer.material.color;
    }
    public void Flash()
    {
        _renderer.material.color = _flashColour;
        Invoke("ResetColor", flashTime);
    }
    void ResetColor()
    {
        _renderer.material.color = origionalColour;
    }
}
