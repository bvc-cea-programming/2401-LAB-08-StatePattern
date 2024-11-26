using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;
    private GameState gameState;
    public GameState GameState => gameState;
    private GameOverState gameOverState;
    public GameOverState GameOverState => gameOverState;
    private MenuState menuState;
    public MenuState MenuState => menuState;

    // Create new private states. MenuState, GameState, GameOverState
    
    // Create new public properties for each state. MenuState, GameState, GameOverState
    

    private void Awake()
    {
        gameOverState = new GameOverState(this);
        gameState = new GameState(this);
        menuState = new MenuState(this);
        // Initialize the states
    }

    private void Start()
    {
        SetState(menuState);
        // open the menu
    }
    
    public void StartGame()
    {
        SetState(gameState);
        // start the game
    }

    public void GotoMenu()
    {
        SetState(menuState);
        // go to menu
    }
}
