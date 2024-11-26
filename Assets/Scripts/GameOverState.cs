using UnityEngine;

public class GameOverState : BaseState
{
    private GameStateMachine _gameStateMachine;
   

    public GameOverState(GameStateMachine gameStateMachine)
    {
        _gameStateMachine = gameStateMachine;
    }
    public override void EnterState()
    {
        _gameStateMachine.UIManager.ShowGameOver(_gameStateMachine.GameManager.Score);
        int highScore = _gameStateMachine.GameManager.GetHighScore();
        _gameStateMachine.UIManager.SetGameEndScore(_gameStateMachine.GameManager.Score, highScore);
        _gameStateMachine.GameManager.SetHighScore();
    }

    public override void ExitState()
    {
       
    }

    public override void UpdateState()
    {
       
    }

}
