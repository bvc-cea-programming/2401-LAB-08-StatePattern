using UnityEngine;

public class GameOverState : BaseState
{
    GameStateMachine _stateMachine;
    public GameOverState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    public override void EnterState()
    {
        _stateMachine.UIManager.ShowGameOver(_stateMachine.GameManager.Score);
        _stateMachine.UIManager.SetGameEndScore(_stateMachine.GameManager.Score, _stateMachine.GameManager.GetHighScore());
    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {

    }

}
