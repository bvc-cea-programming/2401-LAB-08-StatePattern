public class GameState : BaseState
{
    private GameStateMachine _machine;
    public GameState(GameStateMachine state) 
    {
        _machine = state;
    }
    public override void EnterState()
    {
        _machine.GameManager.Reset();
        _machine.UIManager.ShowGame();
        _machine.GameManager.OnScoreChanged += _machine.UIManager.SetGameScore;
      

    }
    public override void UpdateState()
    {
        //timer
        _machine.GameManager.UpdateTimer();
        _machine.GameManager.OnTimerChanged += _machine.UIManager.SetGameTimer;
        if(_machine.GameManager.Timer <= 0)
        {
            _machine.SetState(_machine.GameOverState);
        }         

    }
    public override void ExitState()
    {
        _machine.GameManager.OnTimerChanged -= _machine.UIManager.SetGameTimer;
        _machine.GameManager.OnScoreChanged -= _machine.UIManager.SetGameScore;
       
    }
}
