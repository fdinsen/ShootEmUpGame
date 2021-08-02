using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashHandler : MonoBehaviour
{
    [Header("Global")]
    [SerializeField] private float _flashTime = 0.01f;

    [Header("GameObject Flashing")]
    [SerializeField] private bool _doFlashObject = true;
    [SerializeField] private Color _flashColour;

    [Header("Screen Flashing")]
    [SerializeField] private bool _doFlashScreen = false;
    [SerializeField] private Color _screenFlashColour;


    private Color originalColour;
    private Color originalScreenColour;
    
    private MeshRenderer _renderer;
    private Image _image;
    void Start()
    {
        if(_doFlashObject)
        {
            _renderer = GetComponentInChildren<MeshRenderer>();
            originalColour = _renderer.material.color;
        }

        if(_doFlashScreen)
        {
            _image = GetComponentInChildren<Image>();
            originalScreenColour = _image.color;
        }
    }
    public void Flash()
    {
        TryFlashObject();
        TryFlashScreen();
    }

    void TryFlashObject()
    {
        if (_doFlashObject)
        {
            if (_renderer == null)
            {
                Debug.LogError("MeshRenderer for flashing object not found on GameObject: " + gameObject.name);
            }
            else
            {
                StartCoroutine(DoFlashObject(_flashTime));
            }
        }
    }

    void TryFlashScreen()
    {
        if (_doFlashScreen)
        {
            if (_image == null)
            {
                Debug.LogError("Image for flashing screen not found on object: " + gameObject.name);
            }
            else
            {
                StartCoroutine(DoFlashScreen(_flashTime));
            }
        }
    }

    IEnumerator DoFlashObject(float flashTime)
    {
        _renderer.material.color = _flashColour;
        yield return new WaitForSeconds(flashTime);
        _renderer.material.color = originalColour;
    }

    IEnumerator DoFlashScreen(float flashTime)
    {
        _image.color = _screenFlashColour;
        yield return new WaitForSeconds(flashTime);
        _image.color = originalScreenColour;
    }
}
