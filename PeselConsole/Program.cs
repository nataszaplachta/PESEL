using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeselConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój numer PESEL:");
            string stringPesel = Console.ReadLine();

            if (stringPesel.Length>11 || stringPesel.Length<11)
            {
                Console.WriteLine("Pesel niepoprawny");
                Console.ReadKey();
            }           

            double pesel;

            bool isNum = double.TryParse(stringPesel, out pesel);

            if (isNum == false)
            {
                Console.WriteLine("Pesel może zawierać wyłącznie liczby");
                Console.ReadKey();

            }


            string stringRok = $"{stringPesel[0]}{stringPesel[1]}";
            int intRok = Convert.ToInt32(stringRok);
            string stringMiesiac = $"{stringPesel[2]}{stringPesel[3]}";
            int intMiesiac = Convert.ToInt32(stringMiesiac);
            string stringDzien = $"{stringPesel[4]}{stringPesel[5]}";
            int intDzien = Convert.ToInt32(stringDzien);
            int miesiac = 0;
            string rok = null;
            if (intMiesiac>=81 && intMiesiac <=92)
            {
                miesiac = intMiesiac - 80;
                rok = $"18{intRok}";
            }
            if (intMiesiac>=01 && intMiesiac <=12 )
            {
                miesiac = intMiesiac;
                rok = $"19{intRok}";
            }
            if (intMiesiac >= 21 && intMiesiac <= 32)
            {
                miesiac = intMiesiac - 20;
                rok = $"20{intRok}";
            }
            if (intMiesiac >= 41 && intMiesiac <= 52)
            {
                miesiac = intMiesiac - 40;
                rok = $"21{intRok}";
            }
            if (intMiesiac >= 61 && intMiesiac <= 72)
            {
                miesiac = intMiesiac - 60;
                rok = $"22{intRok}";
            }

            string stringPlec = $"{stringPesel[9]}";
            int intPlec = Convert.ToInt32(stringPlec);
            string plec = null;
            if (intPlec % 2 == 0)
            {
                plec = "Kobieta";
            }
            else plec = "Mężczyzna";

            double a = Char.GetNumericValue(stringPesel[0]);
            double b = Char.GetNumericValue(stringPesel[1]);
            double c = Char.GetNumericValue(stringPesel[2]);
            double d = Char.GetNumericValue(stringPesel[3]);
            double e = Char.GetNumericValue(stringPesel[4]);
            double f = Char.GetNumericValue(stringPesel[5]);
            double g = Char.GetNumericValue(stringPesel[6]);
            double h = Char.GetNumericValue(stringPesel[7]);
            double i = Char.GetNumericValue(stringPesel[8]);
            double j = Char.GetNumericValue(stringPesel[9]);

            double numerKontrolny = Char.GetNumericValue(stringPesel[10]);;

           double x =  9*a + 7*b + 3*c + 1*d + 9*e + 7*f + 3*g + 1*h + 9*i + 7*j;

            if (x % 10 != numerKontrolny)
            {
                Console.WriteLine("Pesel niepoprawny");
                Console.ReadKey();
            }
            else
            {
                string result = $"Data urodzenia: {rok}-{miesiac}-{intDzien}. Płeć: {plec}";
                Console.WriteLine(result);
                Console.ReadKey();
            }







        }
    }
}
