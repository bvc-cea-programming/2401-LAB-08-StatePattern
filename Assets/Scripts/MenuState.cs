using UnityEngine;
using UnityEngine.InputSystem.Android;

public class MenuState : BaseState
{
    private GameStateMachine _gameStateMachine;
    

    public MenuState(GameStateMachine gameStateMachine)
    {
        _gameStateMachine = gameStateMachine;
    }
    
    public override void EnterState()
    {
        _gameStateMachine.UIManager.ShowMenu();
        _gameStateMachine.UIManager.SetMenuHighScore(_gameStateMachine.GameManager.GetHighScore());
    }

    public override void ExitState()
    {
        
    }

    public override void UpdateState()
    {
        
    }

}
