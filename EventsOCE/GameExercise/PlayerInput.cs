namespace EventsOCE.GameExercise;

public class PlayerInput {
    public delegate void PlayerInputHandler(List<ConsoleKey> key);


    private List<ConsoleKey> inputs = new List<ConsoleKey>();
    public event PlayerInputHandler OnPlayerInput;

    public void HandleInputs() {
        while (true) {
            var key = Console.ReadKey(true).Key;
            if (inputs.Count == 0 || inputs[inputs.Count - 1] != key) {
                inputs.Add(key);
            }
        }
    }

    public void OnTick() {
        OnPlayerInput?.Invoke(inputs);
        inputs.Clear();
    }
}