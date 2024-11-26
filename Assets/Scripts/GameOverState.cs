using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverState : BaseState
{
    private GameStateMachine gameStateMachine;
    public GameOverState(GameStateMachine currentMachine)
    {
        gameStateMachine = currentMachine;
    }

    public override void EnterState()
    {
        gameStateMachine.UIManager.ShowGameOver(gameStateMachine.GameManager.Score);
        gameStateMachine.GameManager.SetHighScore();
        gameStateMachine.UIManager.SetGameEndScore(gameStateMachine.GameManager.Score, gameStateMachine.GameManager.GetHighScore());
    }
    public override void UpdateState() { }
    public override void ExitState() { }
}
