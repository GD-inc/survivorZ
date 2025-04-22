using UnityEngine;

public class MenuInput
{
    private InputSystemActions.MenuActions _menuActions;
    private bool _isActive;

    public bool IsActive
    {
        get => _isActive;
        private set => _isActive = value;
    }

    public MenuInput(InputSystemActions.MenuActions menuActions)
    {
        _menuActions = menuActions;
    }

    public void Activate(bool value)
    {
        if (value)
        {
            IsActive = true;
            _menuActions.Enable();
        }
        else
        {
            IsActive = false;
            _menuActions.Disable();
        }
    }
}