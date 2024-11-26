using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;

    // Create new private states. MenuState, GameState, GameOverState
    private MenuState _menustate;
    private GameState _gamestate;
    private GameOverState _gameoverstate;

    // Create new public properties for each state. MenuState, GameState, GameOverState
    public MenuState MenuState => _menustate;
    public GameState GameState => _gamestate;
    public GameOverState GameOverState => _gameoverstate;


    private void Awake()
    {
        // Initialize the states
        _menustate = new MenuState(this);
        _gamestate = new GameState(this);
        _gameoverstate = new GameOverState(this);
    }

    private void Start()
    {
        // open the menu
        SetState(_menustate);
    }

    public void StartGame()
    {
        // start the game
        SetState(_gamestate);
    }

    public void GotoMenu()
    {
        // go to menu
        SetState(_menustate);
    }
}
