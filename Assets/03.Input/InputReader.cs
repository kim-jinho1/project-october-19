using UnityEngine;
using System;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "SO/InputReader")]
public class InputReader : ScriptableObject,PlayerInput.IWActions

{
    public event Action<Vector3> OnMove;

    public event Action OnKey;

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
        inputVector = context.ReadValue<Vector3>();
        OnMove?.Invoke(inputVector);
    }

    public void OnW2(InputAction.CallbackContext context)
    {
        if (context.performed)
            OnKey?.Invoke();
    }
}
