using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static InputReader;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

[CreateAssetMenu(menuName = "SO/InputReader")]
public class InputReader : ScriptableObject,PlayerInput.IWActions

{
    public event Action<Vector3> OnMove;                      

    private PlayerInput _playerInputAction;

    public Vector2 inputVector;
    
    private void OnEnable()
    {
        if (_playerInputAction == null)
        {
            _playerInputAction = new PlayerInput();
            _playerInputAction.W.SetCallbacks(this);
        }
        _playerInputAction.W.Enable(); 
    }


    public void OnW(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<vecter2>();
        OnMove?.Invoke(inputVector);
    }
}
