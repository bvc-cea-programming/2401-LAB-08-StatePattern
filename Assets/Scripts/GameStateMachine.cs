using System;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

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
    public GameState GameState => gameState;    
    public GameOverState GameOverState => gameOverState;
    public MenuState MenuState => menuState;

    private void Awake()
    {
        // Initialize the states
   
        menuState =new MenuState(this);
        gameState = new GameState(this);
        gameOverState =new GameOverState(this);
    }

    private void Start()
    {
        // open the menu
        uiManager.ShowMenu();

    }
    
    public void StartGame()
    {
        // start the game

    }

    public void GotoMenu()
    {
        // go to menu
    }
}
