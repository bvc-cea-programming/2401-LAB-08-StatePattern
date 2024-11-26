using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;

    // Create new private states. MenuState, GameState, GameOverState
    private GameState gameState;
    public GameState GameState => gameState;

    private GameOverState gameOverState;
    public GameOverState GameOverState => gameOverState;
    private MenuState menuState;
    public MenuState MenuState => menuState;
    
    // Create new public properties for each state. MenuState, GameState, GameOverState
    

    private void Awake()
    {
        // Initialize the states
        gameOverState = new GameOverState(this);
        gameState = new GameState(this);
        menuState = new MenuState(this);
    }

    private void Start()
    {
        SetState(menuState);
        // open the menu
    }
    
    public void StartGame()
    {
        // start the game
        SetState(gameState);
    }

    public void GotoMenu()
    {
        // go to menu
        SetState(menuState);
    }
}
