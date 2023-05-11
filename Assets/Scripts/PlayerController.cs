using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    [SerializeField]
    private float moveSpeed;
    //want to keep track of the camera position so the player moves where the camera is facing
    private Transform cameraTransform;
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
        //cameraTransform = Camera.main.transform;
    }
    private void Update()
    {
        transform.position += playerInput.Player.Movement.ReadValue<Vector3>() * moveSpeed * Time.deltaTime;
    }
}
