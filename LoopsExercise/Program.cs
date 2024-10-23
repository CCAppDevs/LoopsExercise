namespace LoopsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // shopping list app

            string[] items = new string[10];

            // ["toast"]["jelly"][][][][][]

            items[0] = "toast";
            items[1] = "jelly";

            List<string> list = new List<string>();

            list.Add("toast");
            list.Add("jelly");
            list.Add("taco");

            for (int start = 0; start < 10; start++)
            {
                list.Add("Item #" + start);
            }

            Console.WriteLine("There are " + list.Count + " items in the list");

            Console.WriteLine("The shopping list:");
            // for each element in the array
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("Showing grid");

            string[,] chessboard = { 
                { "a", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "b", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "c", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "d", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "e", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "f", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "g", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "h", "1", "2", "3", "4", "5", "6", "7", "8" }, 
                { "i", "1", "2", "3", "4", "5", "6", "7", "8" }
            };

            int count = 0;
            while (count < 5)
            {
                // did a thing 5 times
                count++;
            }

            do
            {
                // does a thing once
                // then checks to see if additional loops are needed
            } while (count < 5);

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    Console.Write("[" + chessboard[row,col] + "]");

                }
                Console.WriteLine();
            }
        }
    }
}