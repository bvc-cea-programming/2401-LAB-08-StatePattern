using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MenuState : BaseState
{
    private GameStateMachine gameStateMachine;
    public MenuState(GameStateMachine currentMachine)
    {
        gameStateMachine = currentMachine;
    }

    public override void EnterState()
    {
        gameStateMachine.UIManager.ShowMenu();
        gameStateMachine.UIManager.SetMenuHighScore(gameStateMachine.GameManager.Score);
    }
    public override void UpdateState() { }
    public override void ExitState() { }
}
