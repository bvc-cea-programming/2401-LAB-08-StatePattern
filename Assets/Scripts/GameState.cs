using UnityEngine;

public class GameState : BaseState
{
    private GameStateMachine _stateMachine;

    public GameState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        // Reset the game
        _stateMachine.GameManager.Reset();

        // Show the game canvas
        _stateMachine.UIManager.ShowGame();

        // Subscribe to timer and score events
        _stateMachine.GameManager.OnTimerChanged += _stateMachine.UIManager.SetGameTimer;
        _stateMachine.GameManager.OnScoreChanged += _stateMachine.UIManager.SetGameScore;
    }

    public override void UpdateState()
    {
        // Update the timer
        _stateMachine.GameManager.UpdateTimer();

        // Check if the timer has reached zero
        if (_stateMachine.GameManager.Timer <= 0)
        {
            _stateMachine.GotoGameOver();
        }
    }

    public override void ExitState()
    {
        // Unsubscribe from timer and score events
        _stateMachine.GameManager.OnTimerChanged -= _stateMachine.UIManager.SetGameTimer;
        _stateMachine.GameManager.OnScoreChanged -= _stateMachine.UIManager.SetGameScore;
    }
}
