
public class GameOverState : BaseState
{
    private GameStateMachine stateMachine;
    
    public GameOverState(GameStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    public override void EnterState()
    {
        int currentScore = stateMachine.GameManager.Score;
        stateMachine.UIManager.ShowGameOver(currentScore);
        stateMachine.GameManager.SetHighScore();
        int highScore = stateMachine.GameManager.Score;
        stateMachine.UIManager.SetGameEndScore(currentScore,highScore);
    }

    public override void UpdateState()
    {
      
    }

    public override void ExitState()
    {
    
    }
}
