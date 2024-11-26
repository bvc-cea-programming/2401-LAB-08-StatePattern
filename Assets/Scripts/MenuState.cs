using UnityEngine;

public class MenuState : BaseState
{
    private GameStateMachine _stateMachine;

    public MenuState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        _stateMachine.UIManager.ShowMenu();
        _stateMachine.UIManager.SetMenuHighScore(_stateMachine.GameManager.GetHighScore());
    }

    public override void UpdateState()
    {
        
    }
    public override void ExitState()
    {
    }

   
}
