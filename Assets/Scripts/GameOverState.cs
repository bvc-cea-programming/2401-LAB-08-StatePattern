public class GameOverState : BaseState
{
    private GameStateMachine _stateMachine;

    public GameOverState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        // Show the Game Over canvas
        _stateMachine.UIManager.ShowGameOver(_stateMachine.GameManager.Score);

        // Update the final score and high score
        int score = _stateMachine.GameManager.Score;
        int highScore = _stateMachine.GameManager.GetHighScore();
        _stateMachine.UIManager.SetGameEndScore(score, highScore);

        // Update high score in PlayerPrefs
        _stateMachine.GameManager.SetHighScore();
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {
        
    }
}