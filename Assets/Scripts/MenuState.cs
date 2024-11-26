using UnityEngine;

public class MenuState : BaseState
{
    private GameStateMachine gameStateM;

    public MenuState(GameStateMachine gStateMachine)
    {
        this.gameStateM = gStateMachine;
    }

    public override void ExitState()
    {
        
    }

    public override void EnterState()
    {
        gameStateM.UIManager.ShowMenu();
        gameStateM.UIManager.SetMenuHighScore(gameStateM.GameManager.GetHighScore());
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
