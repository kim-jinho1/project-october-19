using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Base setup")]
    public float _Speed = 7.5f;
    
    
    [Header("Camera")]
    private Camera _PlayerCamera;
    [SerializeField] private Transform _cameraPosition;
    
    [Header("Animator Setup")]
    public Animator animator;

    CharacterController _characterController;
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _characterController.Move(Vector3.right * (_Speed * Time.deltaTime));
        }
    }
}
