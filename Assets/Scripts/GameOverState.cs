using UnityEngine;

public class GameOverState : BaseState
{
    private GameStateMachine gameStateMach;
    public GameOverState(GameStateMachine gameStateMachine)
    {
        this.gameStateMach = gameStateMachine;
    }
    public override void ExitState()
    {

    }
    public override void EnterState()
    {
        gameStateMach.UIManager.ShowGameOver(gameStateMach.GameManager.Score);
        gameStateMach.UIManager.SetGameEndScore(gameStateMach.GameManager.Score,gameStateMach.GameManager.GetHighScore());
        gameStateMach.GameManager.SetHighScore();
        
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
