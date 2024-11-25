using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;

    // Create new private states. MenuState, GameState, GameOverState

    // Private state variables
    private MenuState _menuState;
    private GameState _gameState;
    private GameOverState _gameOverState;

    // Track the current state
    private BaseState _currentState;
    
    // Create new public properties for each state. MenuState, GameState, GameOverState

    // Public properties for states
    public MenuState MenuState => _menuState;
    public GameState GameState => _gameState;
    public GameOverState GameOverState => _gameOverState;
    

    private void Awake()
    {
        // Initialize the states
        _menuState = new MenuState(this);
        _gameState = new GameState(this);
        _gameOverState = new GameOverState(this);
    }

    private void Start()
    {
        // Open the menu
        TransitionToState(_menuState);
    }

    public override void Update()
    {
        // Call UpdateState() of the current state every frame
        _currentState?.UpdateState();
    }

    public void StartGame()
    {
        // Start the game
        TransitionToState(_gameState);
    }

    public void GotoMenu()
    {
        // Go to menu
        TransitionToState(_menuState);
    }

    public void GotoGameOver()
    {
        // Go to the game over state
        TransitionToState(_gameOverState);
    }

    private void TransitionToState(BaseState newState)
    {
        if (_currentState != null)
        {
            _currentState.ExitState();
        }

        _currentState = newState;
        _currentState.EnterState();
    }
}
