using ECM.Controllers;
using UnityEngine;

public sealed class PlayerController : BaseCharacterController
{
    private PlayerInput _playerInput;

    private void Start()
    {
        _playerInput = GameInput.Instance.PlayerInput;
    }

    protected override void HandleInput()
    {
        Vector2 moveVector = _playerInput.GetMovementVector();

        moveDirection = new Vector3
        {
            x = moveVector.x,
            y = 0f,
            z = moveVector.y
        };

        jump = _playerInput.IsJumping();
    }

    protected override void UpdateRotation()
    {
        Vector3 rotateVector = _playerInput.GetRotationVector();
        RotateTowards(rotateVector, true);
    }
}