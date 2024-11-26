public class MenuState : BaseState
{
    private GameStateMachine _machine;
    public MenuState(GameStateMachine state)
    {
        _machine = state;
    }
    public override void EnterState()
    {
        _machine.UIManager.ShowMenu();
        var highScore = _machine.GameManager.GetHighScore();
        _machine.GameManager.SetHighScore();
        _machine.UIManager.SetMenuHighScore(highScore);

    }
    public override void UpdateState()
    {

    }
    public override void ExitState()
    {

    }
}
