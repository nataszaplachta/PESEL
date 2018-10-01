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

            if (stringPesel.Length>11)
            {
                throw new ArgumentException("Zbyt długi numer PESEL");
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
            

            string dataUrodzenia = $"Data urodzenia: {intDzien}.{miesiac}.{rok}";
            Console.WriteLine(dataUrodzenia);







        }
    }
}
