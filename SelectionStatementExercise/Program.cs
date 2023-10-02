namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");
            var guess = int.Parse(Console.ReadLine());

            if (guess > favNumber)
            {
                Console.Write("too high");
            }
            if (guess < favNumber)
            {
                Console.Write("too low");
            }
            else Console.Write("You guessed it!");
        }
    }
}
