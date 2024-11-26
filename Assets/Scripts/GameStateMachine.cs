using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;

    private MenuState menuState;
    private GameState gameState;
    private GameOverState gameOverState;

    public MenuState MenuState => menuState;
    public GameState GameState => gameState;
    public GameOverState GameOverState => gameOverState;
    // Create new private states. MenuState, GameState, GameOverState
    
    // Create new public properties for each state. MenuState, GameState, GameOverState
    

    private void Awake()
    {
        menuState = new MenuState(this);
        gameState = new GameState(this);
        gameOverState = new GameOverState(this);
        // Initialize the states
    }

    private void Start()
    {
        // open the menu
        SetState(menuState);
    }
    
    public void StartGame()
    {
        // start the game
        SetState(gameState);
    }

    public void GotoMenu()
    {
        // go to menu
        SetState(MenuState);
    }
}
