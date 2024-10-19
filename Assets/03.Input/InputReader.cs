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

//[CreateAssetMenu(menuName = "SO/InputReader")]
public class InputReader : ScriptableObject

{
    public event Action<Vector2> OnMove;                      
    public event Action OnJumpPressed, OnJumpReleased;         

    private PlayerInput _playerInputAction;

    public Vector2 inputVector;
    
    private void OnEnable()
    {
        if (_playerInputAction == null)
        {
            _playerInputAction = new PlayerInput();
           // _playerInputAction.W.SetCallbacks(this); //�÷��̾� ��ǲ�� �߻��ϸ� �� �ν��Ͻ��� ����
        }
        _playerInputAction.W.Enable(); //Ȱ��ȭ
    }
}
