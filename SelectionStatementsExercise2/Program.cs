namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hey, What is your favourite school subject?");
            var favouriteSubject =Console.ReadLine();
            switch(favouriteSubject)
            {
                case "math":
                    Console.WriteLine("Wow!i see you love math");
                    break;
                case "biology":
                    Console.WriteLine("Is biology your favourite subject?");
                    break;
                case "history":
                    Console.WriteLine("I like history");
                    break;
                case "physics":
                    Console.WriteLine("Physics is a bit challenging");
                    break;
                case "chemistry":
                    Console.WriteLine("Chemistry is my favourite subject!");
                    break;
                default:
                    Console.WriteLine("Hello, This is not your favourite subject, we will add this");
                 break;   
            }
        }
    }
}