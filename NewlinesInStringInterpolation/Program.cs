namespace NewlinesInStringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchExpression();
            StringMessage();
            Console.ReadLine();
        }

        static void SwitchExpression()
        {
            int rating = 20;
            string evaluation = $"The rating selected is {rating switch
            {
                >= 1 and <= 10 => "beginner",
                >=11 and < 21 => "advanced",
                > 20 and < 51 => "expert",
                _ => "of the scale. ",
            }}.";

            Console.WriteLine(evaluation);
        }

        static void StringMessage()
        {
            string[] fruits = new string[] { "apple", "orange", "grapes" };
            string result = $"The reverse order of fruits are {
                    string.Join(", ", fruits.AsQueryable().Reverse())
                }";
            Console.WriteLine(result);
        }
    }
}
