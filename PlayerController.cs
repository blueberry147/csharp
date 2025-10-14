using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction LeftAction; // The keyword public means that this InputAction will be available to you in the Unity Editor.
    public InputAction MoveAction;
    void Start()
    {
        /// These instructions will make Unity render the game at 10 frames per second.
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;
        ///
        // LeftAction.Enable();
        MoveAction.Enable();
    }

    void Update() // this function is called every time a new frame is displayed.
    {
        // float horizontal = 0.0f;
        // // if (Keyboard.current.leftArrowKey.isPressed)
        // if (LeftAction.IsPressed())
        // {

        //     horizontal = -1.0f;

        // }
        // else if (Keyboard.current.rightArrowKey.isPressed)
        // {

        //     horizontal = 1.0f;

        // }
        // float vertical = 0.0f;
        // if (Keyboard.current.upArrowKey.isPressed)
        // {
        //     vertical = 1.0f;
        // }
        // else if (Keyboard.current.downArrowKey.isPressed)
        // {
        //     vertical = -1.0f;
        // }

        // Debug.Log(horizontal);
        // Vector2 position = transform.position;
        // position.x = position.x + 0.1f * horizontal;
        // position.y = position.y + 0.1f * vertical;
        // transform.position = position;
        // Left arrow key pressed: current position + (0.1 * -1)
        // Right arrow key pressed: current position + (0.1 * 1)
        // No key pressed: current position + (0.1 * 0)
        // Vector2 position = transform.position;
        // position.x = position.x + 0.1f;
        // transform.position = position;
        Vector2 move = MoveAction.ReadValue<Vector2>(); // move is also 1 or -1 or 0 like when we did it manually
        Debug.Log(move);
        // Vector2 position = (Vector2)transform.position + move * 0.1f;
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;
    }
}
