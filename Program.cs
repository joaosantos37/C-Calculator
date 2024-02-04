//Hey there! The "using System;" at the beginning means we can use some cool stuff from the System namespace.

class Calculator
{
    // This is where the main magic happens! Our program logic lives inside the Calculator class.

    // The Main method is like the superhero entrance. It's where the program starts doing its thing.
    static void Main()
    {
        // We're saying a friendly "Welcome!" to the user.
        Console.WriteLine("Welcome to the Enhanced Calculator!");

        // Now, we're creating a loop that keeps running until the user says they want to leave.
        while (true)
        {
            // We ask the user to type in a math expression or say 'exit' to leave.
            Console.Write("Enter an expression (or 'exit' to quit): ");
            string input = Console.ReadLine();

            // If the user types 'exit', we say goodbye and break out of the loop to end the program.
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            try
            {
                // We're attempting to calculate the result of the user's expression using our special method.
                double result = EvaluateExpression(input);

                // We happily show the result to the user.
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                // Oops! Something went wrong. We're telling the user what went wrong.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // This is our super cool method for doing math. It takes an expression and gives back a result.
    static double EvaluateExpression(string expression)
    {
        // We have a simple way to understand math expressions using a special tool called DataTable.
        var dataTable = new System.Data.DataTable();

        // Now, we're using the DataTable to compute the result of the user's expression.
        var result = dataTable.Compute(expression, string.Empty);

        // We check if the result is a whole number or a decimal.
        if (result is int || result is double)
        {
            // If it is, we convert it to a decimal and hand it back to the main method.
            return Convert.ToDouble(result);
        }
        else
        {
            // Uh-oh! Something unexpected happened. We tell the user there's an issue.
            throw new InvalidOperationException("Invalid expression or result.");
        }
    }
}



