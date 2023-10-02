namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a number quessing game!");
           var  r = new Random();
           var favNumber = r.Next(1,1000);
           int userInput = int.Parse(Console.ReadLine());

            if (userInput < 907) 
            { 
                Console.WriteLine("Too Low");

            }

            else if (userInput > 907)
            {
                Console.WriteLine("Too High");
            }

            else if(userInput == 907)
            {
                Console.WriteLine("You Guessed It, Great Job!");
            }
        }
    }
}
