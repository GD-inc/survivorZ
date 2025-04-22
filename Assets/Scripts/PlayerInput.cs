using UnityEngine;

public class PlayerInput
{
    private InputSystemActions.PlayerActions _playerActions;
    private bool _isActive;

    public bool IsActive
    {
        get => _isActive;
        private set => _isActive = value;
    }

    public PlayerInput(InputSystemActions.PlayerActions playerActions)
    {
        _playerActions = playerActions;
    }

    public Vector2 GetMovementVector()
    {
        return _playerActions.Move.ReadValue<Vector2>();
    }

    public Vector3 GetRotationVector()
    {
        Vector3 mousePosition = _playerActions.Look.ReadValue<Vector2>();
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            return hit.point;
        }

        return Vector3.zero;
    }

    public bool IsJumping()
    {
        return _playerActions.Jump.IsPressed();
    }

    public void Activate(bool value)
    {
        if (value)
        {
            IsActive = true;
            _playerActions.Enable();
        }
        else
        {
            IsActive = false;
            _playerActions.Disable();
        }
    }
}
