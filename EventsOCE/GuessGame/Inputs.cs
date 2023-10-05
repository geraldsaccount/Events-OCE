namespace EventsOCE.GuessGame;

public class Inputs {
    private Game.GuessResult currentResult;

    public delegate void GuessHandler(int guess);

    public event GuessHandler OnGuess;

    public void GetGuessInputs() {
        while (currentResult != Game.GuessResult.Correct) {
            var input = Console.ReadLine();

            try {
                var guess = int.Parse(input);
                OnGuess?.Invoke(guess);
            }
            catch (Exception e) { }
        }
    }

    public void OnGuessChecked(Game.GuessResult result) {
        currentResult = result;
    }
}