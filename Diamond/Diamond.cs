
using static System.Runtime.InteropServices.JavaScript.JSType;
/// <summary>
/// https://codingdojo.org/kata/Diamond/
/// </summary>

namespace Diamond
{
    public class Diamond
    {
        private string lettre;

        public Diamond(string lettre)
        {
            if (!char.IsLetter(lettre, 0))
                throw new ArgumentOutOfRangeException(nameof(lettre));

            this.lettre = lettre.ToUpper();
        }

        private string Generate()
        {
            if (lettre == "A")
                return "A";

            List<string> lignes = new List<string>();

            int positionLettre = Alphabet.Position(lettre);

            //Partie haute du diamant
            int previousSpacesNumber = 1;
            int lineNumber = 1;
            for (int i = 0; i < positionLettre; i++)
            {
                string lettreCourante = Alphabet.Lettre(i + 1);

                string ligne = GetSpaces(positionLettre - lineNumber);

                ligne += lettreCourante;

                if (lettreCourante != "A")
                {
                    if (lettreCourante != "B")
                        previousSpacesNumber += 2;

                    ligne += GetSpacesInbetween(previousSpacesNumber);
                    ligne += lettreCourante;
                }

                lignes.Add(ligne);

                lineNumber++;
            }

            //Partie basse du diamant
            lineNumber = 1;
            for (int i = positionLettre - 1; i > 0; i--)
            {
                string lettreCourante = Alphabet.Lettre(i);

                string ligne = GetSpaces(lineNumber);

                ligne += lettreCourante;

                if (lettreCourante != "A")
                {
                    previousSpacesNumber -= 2;

                    ligne += GetSpacesInbetween(previousSpacesNumber);
                    ligne += lettreCourante;
                }

                lignes.Add(ligne);

                lineNumber++;
            }

            return string.Join("\r\n", lignes);
        }

        private string GetSpacesInbetween(int nombre)
        {
            int spaceNumbers = nombre;
            if (spaceNumbers > 0)
                spaceNumbers = spaceNumbers % 2 == 0 ? spaceNumbers + 1 : spaceNumbers;

            return GetSpaces(spaceNumbers);
        }

        private string GetSpaces(int nombre)
        {
            if (nombre == 0)
                return string.Empty;

            string espaces = "";
            for (int j = 0; j < nombre; j++)
            {
                espaces += " ";
            }

            return espaces;
        }

        public override string ToString()
        {
            return Generate();
        }
    }
}