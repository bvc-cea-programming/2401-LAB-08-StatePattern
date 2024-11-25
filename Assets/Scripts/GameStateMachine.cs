using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;

    // Create new private states. MenuState, GameState, GameOverState
    private MenuState _menuState;
    private GameState _gameState;
    private GameOverState _gameOverState;

    // Create new public properties for each state. MenuState, GameState, GameOverState


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
        // open the menu
        SetState(_menuState);
    }
    
    public void StartGame()
    {
        // start the game
        SetState(_gameState);
    }

    public void GotoMenu()
    {
        // go to menu
        SetState(_menuState);
    }

    public void GoToGameOver()
    {
        SetState(_gameOverState);
    }
}
