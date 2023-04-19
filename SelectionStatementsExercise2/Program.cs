namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject? \n " +
                "Options: Math, Science, History, English, Spanish... or anything else you enjoy :)");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Cool I like math to!");
                    break;
                case "science":
                    Console.WriteLine("Science is cool, it literally explains the world!");
                    break;
                case "history":
                    Console.WriteLine("Ahh very cool, never stop learning history.");
                    break;
                case "english":
                    Console.WriteLine("Eww... Essays :(");
                    break;
                case "spanish":
                    Console.WriteLine("Learning another language is super valuable.");
                    break;
                default:
                    Console.WriteLine($"{favSubject} is a great subject! Glad you found something you enjoy.");
                    break;
            }

        }
    }
}