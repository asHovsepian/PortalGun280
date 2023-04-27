using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    [SerializeField]
    private float moveSpeed;
    private void Awake()
    {
        playerInput = new PlayerInput();
    }
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position += playerInput.Player.Movement.ReadValue<Vector3>() * moveSpeed * Time.deltaTime;
    }
}
