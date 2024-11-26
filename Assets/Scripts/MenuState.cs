using UnityEngine;

public class MenuState : BaseState
{
    private GameStateMachine _gameStateMachine;

    public MenuState(GameStateMachine gameStateMachine)
    {
        _gameStateMachine = gameStateMachine;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void EnterState()
    {
        _gameStateMachine.UIManager.ShowMenu();
        _gameStateMachine.UIManager.SetMenuHighScore(_gameStateMachine.GameManager.GetHighScore());
    }

    public override void UpdateState()
    {

    }
    public override void ExitState()
    {

    }
}
