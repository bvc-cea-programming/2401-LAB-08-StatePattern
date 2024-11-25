using UnityEngine;

public class MenuState : BaseState
{
    private GameStateMachine _machine;
    private MenuState()
    {
        _machine = new GameStateMachine();
    }
    public override void EnterState()
    { }
    public override void UpdateState()
    { }
    public override void ExitState()
    { }
}
