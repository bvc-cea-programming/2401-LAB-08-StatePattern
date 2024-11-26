public class GameOverState : BaseState
{
    private GameStateMachine _machine;
    public GameOverState(GameStateMachine state)
    {
        _machine = state;
    }
    public override void EnterState()
    {

        _machine.UIManager.ShowGameOver(_machine.GameManager.Score);

        var currentScore = _machine.GameManager.Score;
        var highScore = _machine.GameManager.GetHighScore();
        _machine.GameManager.SetHighScore();
        _machine.UIManager.SetGameEndScore(currentScore, highScore);

    }
    public override void UpdateState()
    {

    }
    public override void ExitState()
    {



        _machine.UIManager.ShowGameOver(_machine.GameManager.Score);
    }
}
