
/// <summary>
/// https://codingdojo.org/kata/Diamond/
/// </summary>
namespace Diamond
{
    internal class Alphabet
    {
        private static string[] alphabet = new string[26]{
            "A", "B", "C", "D", "E",
            "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O",
            "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y",
            "Z"
            };

        internal static string Lettre(int v)
        {
            return alphabet[v - 1];
        }

        internal static int Position(string lettre)
        {
            for (int position = 0; position < alphabet.Length; position++)
            {
                if (lettre == alphabet[position])
                    return position + 1;
            }

            throw new ArgumentOutOfRangeException(nameof(lettre), lettre);
        }
    }
}