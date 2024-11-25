using UnityEngine;

public class MenuState : BaseState
{
    GameStateMachine _stateMachine;

    public MenuState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    public override void EnterState()
    {
        _stateMachine.UIManager.ShowMenu();
    }

    public override void ExitState()
    {
        
    }

    public override void UpdateState()
    {
        
    }


}
