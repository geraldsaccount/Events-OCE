namespace EventsOCE.CalculatorExercise; 

public class Calculator {
    public delegate int Calculation(int a, int b);
    
    public void Start() {
        Calculation calculation = Add;
        int a = 10;
        int b = 6;
        
        
        int selection = int.Parse(Console.ReadLine());

        switch (selection) {
            case 1:
                calculation = Add;
                break;
            case 2:
                calculation = Subtract;
                break;
            case 3: 
                calculation = Multiply;
                break;
            case 4:
                calculation = (lhs, rhs) => {
                    return lhs / rhs;
                };
                break;
        }
        
        Console.WriteLine($"Result = {calculation(a, b)}");
    }

    private int Subtract(int a, int b) {
        return a - b;
    }

    private int Add(int lhs, int rhs) {
        return lhs + rhs;
    }
    private int Multiply(int lhs, int rhs) {
        return lhs * rhs;
    }
}