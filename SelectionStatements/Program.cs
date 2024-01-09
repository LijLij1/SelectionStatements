namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;
            var counter = 0;

            do
            {
                Console.WriteLine("Pick a number 1 to 1000.");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("To low!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("To high!");
                }
                else
                {
                    Console.WriteLine("Good job you got it!");
                }

                counter++;
                Console.WriteLine($"You have tried {counter} times!");
            } while (userInput != favNumber);






        }
    }
}