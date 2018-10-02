using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeselConsole;

namespace PeselUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LosowyPeselNumerKontrolny()
        {
            Random r = new Random();      
            int a = r.Next(1, 9);
            int b = r.Next(0, 9);
            int c = r.Next(0, 9);
            int d = r.Next(0, 9);
            int e = r.Next(0, 9);
            int f = r.Next(0, 9);
            int g = r.Next(0, 9);
            int h = r.Next(0, 9);
            int i = r.Next(0, 9);
            int j = r.Next(0, 9);
            int k = r.Next(0, 9);

            string spesel = $"{a}{b}{c}{d}{e}{f}{g}{h}{i}{j}{k}";
            double pesel = Convert.ToDouble(spesel);

            double x = 9 * a + 7 * b + 3 * c + 1 * d + 9 * e + 7 * f + 3 * g + 1 * h + 9 * i + 7 * j;
            double expectedKontrolny = Char.GetNumericValue(spesel[10]);

            double kontrolny = x % 10;

            Assert.AreEqual(kontrolny, expectedKontrolny);

        }

        [TestMethod]

        public void PodanyPeselNumerKontrolny()
        {
            string stringPesel = "95102107704";

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

            double x = 9 * a + 7 * b + 3 * c + 1 * d + 9 * e + 7 * f + 3 * g + 1 * h + 9 * i + 7 * j;
            double expectedKontrolny = Char.GetNumericValue(stringPesel[10]);

            double kontrolny = x % 10;
            Assert.AreEqual(kontrolny, expectedKontrolny);

        }

        [TestMethod]

        public void PodanyPeselZbytDlugi()
        {
            Random r = new Random();
            int a = r.Next(1, 9);
            int b = r.Next(0, 9);
            int c = r.Next(0, 9);
            int d = r.Next(0, 9);
            int e = r.Next(0, 9);
            int f = r.Next(0, 9);
            int g = r.Next(0, 9);
            int h = r.Next(0, 9);
            int i = r.Next(0, 9);
            int j = r.Next(0, 9);
            int k = r.Next(0, 9);

            string spesel = $"{a}{b}{c}{d}{e}{f}{g}{h}{i}{j}{k}";

            bool dPesel = true;
            dPesel = spesel.Length == 11;
            bool expected = true;

            Assert.AreEqual(expected, dPesel);
        }
        [TestMethod]

        public void LosowyyPeselZbytDlugi()
        {
            string stringPesel = "95102107704";

            bool dPesel = true;
            dPesel = stringPesel.Length == 11;
            bool expected = true;

            Assert.AreEqual(expected, dPesel);
        }

    }
}
