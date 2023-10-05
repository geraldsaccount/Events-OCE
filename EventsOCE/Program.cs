
using EventsOCE.GuessGame;

namespace EventsOCE
{
    public class Program {
        public static ConsoleColor DefaultColor;
        
        static void Main(string[] args) {
            DefaultColor = Console.ForegroundColor;

            Game game = new Game();
            game.Start();
        }
    }
}