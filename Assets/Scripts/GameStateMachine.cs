using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;

    // Create new private states. MenuState, GameState, GameOverState
    private MenuState menuState;
    private GameState gameState;
    private GameOverState gameOverState;
    // Create new public properties for each state. MenuState, GameState, GameOverState
    public MenuState MenuState => menuState;
    
    public GameState GameState => gameState;
    
    public GameOverState GameOverState => gameOverState;
    

    private void Awake()
    {
        // Initialize the states
        menuState = new MenuState(this);
        gameState = new GameState(this);
        gameOverState = new GameOverState(this);
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
        SetState(menuState);
    }
}
