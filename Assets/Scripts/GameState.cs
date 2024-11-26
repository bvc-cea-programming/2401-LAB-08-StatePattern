using UnityEngine;

public class GameState : BaseState
{
    private GameStateMachine stateMachine;
    public GameState(GameStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void EnterState()
    {
        stateMachine.GameManager.Reset();
        stateMachine.UIManager.ShowGame();
        stateMachine.GameManager.OnScoreChanged += stateMachine.UIManager.SetGameScore;
        stateMachine.GameManager.OnTimerChanged += stateMachine.UIManager.SetGameTimer;
    }

    public override void UpdateState()
    {
        stateMachine.GameManager.UpdateTimer();

        if (stateMachine.GameManager.Timer <= 0)
        {
            stateMachine.SetState(stateMachine.GameOverState);
        }
    }

    public override void ExitState()
    {
        stateMachine.GameManager.OnScoreChanged -= stateMachine.UIManager.SetGameScore;
        stateMachine.GameManager.OnTimerChanged -= stateMachine.UIManager.SetGameTimer;
    }
}
