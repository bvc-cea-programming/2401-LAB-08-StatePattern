using System.Diagnostics;

public class MenuState : BaseState
{
    private GameStateMachine _stateMachine;

    public MenuState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        // Show the menu UI
        _stateMachine.UIManager.ShowMenu();

        // Update the high score display
        int highScore = _stateMachine.GameManager.GetHighScore();
        _stateMachine.UIManager.SetMenuHighScore(highScore);
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {
        
    }
}