using TMPro;
using UnityEngine;

public class GameOverState : BaseState
{
    private GameStateMachine _stateMachine;

    public GameOverState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        _stateMachine.UIManager.ShowGameOver(_stateMachine.GameManager.Score);
        _stateMachine.UIManager.SetGameEndScore(_stateMachine.GameManager.Score, _stateMachine.GameManager.GetHighScore());
        _stateMachine.GameManager.SetHighScore();
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {

    }
}
