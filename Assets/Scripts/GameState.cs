using UnityEngine;

public class GameState :BaseState
{
    private GameStateMachine _stateMachine;
    
    public GameState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    public override void EnterState()
    {
        _stateMachine.GameManager.Reset();
        _stateMachine.UIManager.ShowGame();
        _stateMachine.GameManager.OnScoreChanged += _stateMachine.UIManager.SetGameScore;
        _stateMachine.GameManager.OnTimerChanged += _stateMachine.UIManager.SetGameTimer;
    }

    public override void UpdateState()
    {
        _stateMachine.GameManager.UpdateTimer();
        if(_stateMachine.GameManager.Timer <= 0)
        {
            _stateMachine.SetState(_stateMachine.GameOverState);
        }
    }
    public override void ExitState()
    {
        _stateMachine.GameManager.OnScoreChanged -= _stateMachine.UIManager.SetGameScore;
        _stateMachine.GameManager.OnTimerChanged -= _stateMachine.UIManager.SetGameTimer;
    }
}
