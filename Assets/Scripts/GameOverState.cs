using UnityEngine;

public class GameOverState : BaseState
{
    private GameStateMachine gameStateM;

    public GameOverState(GameStateMachine gStateMachine)
    {
        this.gameStateM = gStateMachine;
    }

    public override void ExitState()
    {

    }

    public override void EnterState()
    {
        gameStateM.UIManager.ShowGameOver(gameStateM.GameManager.Score);
        gameStateM.UIManager.SetGameEndScore(gameStateM.GameManager.Score,gameStateM.GameManager.GetHighScore());
        gameStateM.GameManager.SetHighScore();

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
