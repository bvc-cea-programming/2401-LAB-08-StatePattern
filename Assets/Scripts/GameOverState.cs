using UnityEngine;

public class GameOverState : BaseState
{
    private GameStateMachine _gameStateMachine;

    public GameOverState(GameStateMachine gameStateMachine)
    {
        _gameStateMachine = gameStateMachine;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void EnterState()
    {
        _gameStateMachine.UIManager.ShowGameOver(_gameStateMachine.GameManager.Score);
        _gameStateMachine.UIManager.SetGameEndScore(_gameStateMachine.GameManager.Score, _gameStateMachine.GameManager.GetHighScore());
        _gameStateMachine.GameManager.SetHighScore();
    }

    public override void UpdateState()
    {

    }
    public override void ExitState()
    {

    }

}
