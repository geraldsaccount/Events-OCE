namespace EventsOCE.GuessGame; 

public class UI {
    public void DisplayGuess(int guess) {
        Console.Write($"Your guess {guess} ");
    }

    public void DisplayResult(Game.GuessResult result) {
        switch (result) {
            case Game.GuessResult.High:
                Console.WriteLine("is too high.");
                break;
            case Game.GuessResult.Low:
                Console.WriteLine("is too low");
                break;
            case Game.GuessResult.Correct:
                Console.WriteLine("is right.");
                break;
        }
    }
}