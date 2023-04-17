/// <summary>
/// https://codingdojo.org/kata/Diamond/
/// </summary>
namespace Diamond
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string lettre;
            for (int i = 0; i < 26; i++)
            {
                lettre = Alphabet.Lettre(i + 1);
                Console.WriteLine("------------");
                Console.WriteLine("     " + lettre);
                Console.WriteLine("------------");

                var diamond = new Diamond(lettre);
                Console.WriteLine(diamond.ToString());

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}