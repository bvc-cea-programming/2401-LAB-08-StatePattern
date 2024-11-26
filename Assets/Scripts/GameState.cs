using UnityEngine;

public class GameState : BaseState
{
    private GameStateMachine _gameStateMachine; 

    public GameState(GameStateMachine gameStateMachine)
    {
        _gameStateMachine = gameStateMachine;
    }
    public override void EnterState()
    {
        _gameStateMachine.GameManager.Reset();
        _gameStateMachine.UIManager.ShowGame();
        _gameStateMachine.GameManager.OnScoreChanged += _gameStateMachine.UIManager.SetGameScore;
        
    }

    public override void ExitState()
    {
        _gameStateMachine.GameManager.OnScoreChanged += _gameStateMachine.UIManager.SetGameScore;
        _gameStateMachine.GameManager.OnTimerChanged += _gameStateMachine.UIManager.SetGameTimer;
    }

    public override void UpdateState()
    {
        _gameStateMachine.GameManager.UpdateTimer();
        _gameStateMachine.GameManager.OnTimerChanged += _gameStateMachine.UIManager.SetGameTimer;

        if (_gameStateMachine.GameManager.Timer <= 0)
        {
            _gameStateMachine.SetState(_gameStateMachine.GameOverState);
        }
    }

}
