public class MenuState : BaseState
{
    private GameStateMachine stateMachine;
    public MenuState(GameStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    public override void EnterState()
    {
        stateMachine.UIManager.ShowMenu();
        stateMachine.UIManager.SetMenuHighScore(stateMachine.GameManager.GetHighScore());
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {
        
    }
}
