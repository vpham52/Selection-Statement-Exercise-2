namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var faveSubject = Console.ReadLine();

            switch (faveSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is the same no matter where you go.");
                    break;

                case "science":
                    Console.WriteLine("There's so much to learn.");
                    break;

                case "english":
                    Console.WriteLine("Grammar is important.");
                    break;

                case "history":
                    Console.WriteLine("You can't handle the future without the past.");
                    break;

                case "physical education":
                    Console.WriteLine("Book smarts isn't the only thing in life.");
                    break;

                default:
                    Console.WriteLine("Don't know her.");
                    break;
            }

        }
    }
}
