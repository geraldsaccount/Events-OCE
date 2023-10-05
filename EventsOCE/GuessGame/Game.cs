namespace EventsOCE.GuessGame; 

public class Game {
    public enum GuessResult {
        High,
        Low,
        Correct
    }

    public delegate void GuessCheckedHandler(GuessResult result);

    public event GuessCheckedHandler OnGuessChecked;
    
    private int number;
    
    public void Start() {
        Random rand = new Random();
        number = rand.Next(1, 101);

        UI ui = new UI();
        Inputs inputs = new Inputs();
        
        inputs.OnGuess += ui.DisplayGuess;
        inputs.OnGuess += CheckGuess;

        OnGuessChecked += ui.DisplayResult;
        OnGuessChecked += inputs.OnGuessChecked;
        inputs.GetGuessInputs();
    }

    private void CheckGuess(int guess) {
        if (guess > number) {
            OnGuessChecked?.Invoke(GuessResult.High);
        }
        else if (guess < number) {
            OnGuessChecked?.Invoke(GuessResult.Low);
        }
        else {
            OnGuessChecked?.Invoke(GuessResult.Correct);
        }
    }
}