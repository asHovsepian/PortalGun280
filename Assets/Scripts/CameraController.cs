using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    //this stores the action map i created
    private PlayerInput controls;
    //mouse sens
    private float mouseSensitivity = 10f;
    //direction for mouse
    private Vector2 mouseLook;
    //mouse rotation variables
    private float xRotation = 0f;
    private float yRotation = 0f;
    //stores the players transform
    public Transform playerbody;

    private void Awake()
    {
        controls = new PlayerInput();
        controls.Enable();
    }
    private void Start()
    {
        //locks the cursor into the game when testing in unity
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        //Debug.Log(controls.Player.Look.ReadValue<Vector2>());
        mouseLook = controls.Player.Look.ReadValue<Vector2>();
        transform.Rotate(mouseLook.x * Vector3.up * mouseSensitivity * Time.deltaTime);
        transform.Rotate(mouseLook.y * Vector3.left * mouseSensitivity * Time.deltaTime);
    }
}
