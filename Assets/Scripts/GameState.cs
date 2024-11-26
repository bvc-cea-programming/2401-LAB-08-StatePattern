using UnityEngine;

public class GameState : BaseState
{
    private GameStateMachine GameStateM;

    public GameState(GameStateMachine gStateMachine)
    {
        this.GameStateM = gStateMachine;
    }

    public override void ExitState()
    {
        GameStateM.GameManager.OnScoreChanged -= GameStateM.UIManager.SetGameScore;
        GameStateM.GameManager.OnTimerChanged -= GameStateM.UIManager.SetGameTimer;
    }

    public override void EnterState()
    {
        GameStateM.GameManager.Reset();
        GameStateM.UIManager.ShowGame();
        GameStateM.GameManager.OnScoreChanged += GameStateM.UIManager.SetGameScore;
        GameStateM.GameManager.OnTimerChanged += GameStateM.UIManager.SetGameTimer;
    }

    public override void UpdateState()
    {
        GameStateM.GameManager.UpdateTimer();
        if (GameStateM.GameManager.Timer <= 0)
        {
            GameStateM.SetState(GameStateM.GameOverState);
        }
    }
}
