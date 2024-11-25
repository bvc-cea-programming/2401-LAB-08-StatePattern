using UnityEngine;

public class GameState : BaseState
{
    GameStateMachine _stateMachine;
    public GameState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    public override void EnterState()
    {
        _stateMachine.GameManager.Reset();
        _stateMachine.UIManager.SetGameScore(0);
        _stateMachine.UIManager.ShowGame();
        //subscribe the ui to the timer and score changes
        _stateMachine.GameManager.OnTimerChanged += _stateMachine.UIManager.SetGameTimer;
        _stateMachine.GameManager.OnScoreChanged += _stateMachine.UIManager.SetGameScore;
    }

    public override void ExitState()
    {
        //unsubscribe
        _stateMachine.GameManager.OnTimerChanged -= _stateMachine.UIManager.SetGameTimer;
        _stateMachine.GameManager.OnScoreChanged -= _stateMachine.UIManager.SetGameScore;
    }

    public override void UpdateState()
    {
        _stateMachine.GameManager.UpdateTimer();
        if (_stateMachine.GameManager.Timer <= 0)
        {
            _stateMachine.GoToGameOver();
        }
    }

}
