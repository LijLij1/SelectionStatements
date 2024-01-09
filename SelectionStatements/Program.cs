using Microsoft.VisualBasic;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var r = new random();
            //var favnumber = r.next(1, 1000);
            //int userinput;
            //var counter = 0;

            //do
            //{
            //console.writeline("pick a number 1 to 1000.");
            //userinput = int.parse(console.readline());

            //if (userinput < favnumber)
            //{
            //console.writeline("to low!");
            //}
            // else if (userinput > favnumber)
            // {
            //      console.writeline("to high!");
            // }
            // else
            // {
            //Console.WriteLine("good job you got it!");
            // }

            // counter++;
            // console.writeline($"you have tried {counter} times!");
            //  } while (userinput != favnumber);

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                case "calaculus":
                    Console.WriteLine("Math is my favorite!");
                    break;
                case "science":
                    Console.WriteLine("Science is my second favorite@");
                    break;
                case "history":
                    Console.WriteLine("History is boring!");
                    break;
                case "english":
                case "reading":
                    Console.WriteLine("English can be fun!");
                    break;
                case "p.e":
                    Console.WriteLine("I love P.E!");
                    break;
                default:
                    Console.WriteLine("I dont know this subject.");
                    break;
            }




        }
    }
}