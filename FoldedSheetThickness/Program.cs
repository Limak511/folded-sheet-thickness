namespace FoldedSheetThickness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userInput = string.Empty;
            while (true)
            {
                int foldsCount = 0;
                double paperSheetThickness = .15d;

                // validate if user pass number for folds count (instead of passing string, char, floating-point numbers, etc.)
                do
                {
                    Console.Clear();
                    Console.WriteLine("(To exit program type number less than 1)\n\n");
                    Console.Write("Number of folds of the paper: ");
                    userInput = Console.ReadLine();
                } while (!int.TryParse(userInput, out foldsCount));

                // if less than 1 selected, exit program
                if (foldsCount < 1)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("Paper sheet's thickness without folding: 0,1 mm\n\n");

                // fold paper
                for (int i = 1; i <= foldsCount; i++)
                {
                    string foldsCorrectSpelling = i == 1 ? "fold" : "folds";
                    paperSheetThickness *= 2;
                    Console.WriteLine($"Paper sheet's thickness after {i} {foldsCorrectSpelling}\n" +
                    $"-> {paperSheetThickness:N1} mm\n" +
                    $"-> {(paperSheetThickness / 10d):N1} cm\n" +
                    $"-> {(paperSheetThickness / 1000d):N1} m\n" +
                    $"-> {(paperSheetThickness / 1000000d):N1} km\n");
                }

                // wait before clearing screen, to read calculations. Clear view
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
