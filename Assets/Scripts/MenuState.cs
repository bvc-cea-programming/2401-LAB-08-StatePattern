using UnityEngine;

public class MenuState : BaseState
{
    private GameStateMachine gameStateMach;
    public MenuState(GameStateMachine gameStateMachine)
    {
        this.gameStateMach = gameStateMachine;
    }
    public override void ExitState()
    {

    }
    public override void EnterState()
    {
        gameStateMach.UIManager.ShowMenu();
        gameStateMach.UIManager.SetMenuHighScore(gameStateMach.GameManager.GetHighScore());
    }
    public override void UpdateState()
    {
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
