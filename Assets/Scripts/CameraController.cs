using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    //this stores the action map i created
    private PlayerInput controls;
    //mouse sens
    private float mouseSensitivity = 100f;
    //direction for mouse
    private Vector2 mouseLook;
    //mouse rotation
    private float xRotation = 0f;
    //stores the players transform
    public Transform playerbody;

    private void Awake()
    {
        controls = new PlayerInput();
    }
}
