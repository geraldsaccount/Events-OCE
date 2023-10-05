namespace EventsOCE.GameExercise;

public class Game {
    private PlayerInput inputProvider;
    private GameTimer timer;

    public void Start() {
        inputProvider = new PlayerInput();
        timer = new GameTimer(2000);

        timer.OnTick += OnTick;
        timer.OnTick += inputProvider.OnTick;
        inputProvider.OnPlayerInput += PrintPlayerInput;

        inputProvider.HandleInputs();
    }

    private void PrintPlayerInput(List<ConsoleKey> keys) {
        foreach (var consoleKey in keys) {
            Console.WriteLine($"Input: {consoleKey}");
        }
    }

    private void OnTick() {
        Console.WriteLine("Tick");
    }
}