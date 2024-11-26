using UnityEngine;

public class GameState : BaseState
{
    private GameStateMachine gameStateMach;
    public GameState(GameStateMachine gameStateMachine)
    {
        this.gameStateMach = gameStateMachine;
    }
    public override void ExitState()
    {
        gameStateMach.GameManager.OnScoreChanged -= gameStateMach.UIManager.SetGameScore;
        gameStateMach.GameManager.OnTimerChanged -= gameStateMach.UIManager.SetGameTimer;
    }
    public override void EnterState()
    {
        gameStateMach.GameManager.Reset();
        gameStateMach.UIManager.ShowGame();
        gameStateMach.GameManager.OnScoreChanged += gameStateMach.UIManager.SetGameScore;
        gameStateMach.GameManager.OnTimerChanged += gameStateMach.UIManager.SetGameTimer;

    }
    public override void UpdateState()
    {
        gameStateMach.GameManager.UpdateTimer();
        if (gameStateMach.GameManager.Timer <= 0)
        {
            gameStateMach.SetState(gameStateMach.GameOverState);
        }
    }
}
