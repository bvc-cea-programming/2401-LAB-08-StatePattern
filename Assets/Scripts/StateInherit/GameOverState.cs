using UnityEngine;

public class GameOverState : BaseState
{
    private GameStateMachine _machine;
    public GameOverState(GameStateMachine state)
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
