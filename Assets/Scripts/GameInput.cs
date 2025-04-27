using UnityEngine;

public class GameInput : MonoBehaviour
{
    private InputSystemActions _inputSystemActions;
    private PlayerInput _playerInput;
    private MenuInput _menuInput;

    public static GameInput Instance;
    public PlayerInput PlayerInput => _playerInput;
    public MenuInput MenuInput => _menuInput;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        _inputSystemActions = new();

        _playerInput = new(_inputSystemActions.Player);
        _menuInput = new(_inputSystemActions.Menu);

        _playerInput.Activate(true);
    }

    void Start()
    {

    }

    void Update()
    {

    }
}