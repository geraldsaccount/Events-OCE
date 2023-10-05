namespace EventsOCE.GameExercise; 

public class GameTimer {
    private Timer timer;
    public Action OnTick;

    public GameTimer(int tickMilliseconds) {
        timer = new Timer(TimerCallback, null, 0, tickMilliseconds);
    }

    private void TimerCallback(object? state) {
        OnTick?.Invoke();
    }
}