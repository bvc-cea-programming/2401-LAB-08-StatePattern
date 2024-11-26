using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameState : BaseState
{
    private GameStateMachine gameStateMachine;
    public GameState(GameStateMachine currentMachine)
    {
        gameStateMachine = currentMachine;
    }

    public override void EnterState()
    {
        gameStateMachine.GameManager.Reset();
        gameStateMachine.UIManager.ShowGame();
        gameStateMachine.GameManager.OnScoreChanged += gameStateMachine.UIManager.SetGameScore;
        gameStateMachine.GameManager.OnTimerChanged += gameStateMachine.UIManager.SetGameTimer;
    }
    public override void UpdateState()
    {
        gameStateMachine.GameManager.UpdateTimer();
        if (gameStateMachine.GameManager.Timer <= 0)
        {
            gameStateMachine.SetState(gameStateMachine.GameOverState);
        }
    }
    public override void ExitState()
    {
        gameStateMachine.GameManager.OnScoreChanged -= gameStateMachine.UIManager.SetGameScore;
        gameStateMachine.GameManager.OnTimerChanged -= gameStateMachine.UIManager.SetGameTimer;
    }
}
