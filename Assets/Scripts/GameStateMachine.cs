using System;
using UnityEngine;

public class GameStateMachine : BaseStateMachine
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    public GameManager GameManager => gameManager;
    public UIManager UIManager => uiManager;

    // Create new private states. MenuState, GameState, GameOverState
    
    // Create new public properties for each state. MenuState, GameState, GameOverState
    

    private void Awake()
    {
        // Initialize the states
    }

    private void Start()
    {
        // open the menu
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
